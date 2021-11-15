using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Access;

namespace TranManagSysLibrary
{
    /// <summary>
    /// Класс для соединения с базой данных
    /// </summary>
    public static class DBConnection
    {
        //Строка подключения
        static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataBase.mdb;";
        //Подключение
        static OleDbConnection connection;
        static bool connectionSuccessful = false;
        /// <summary>
        /// Создает и открывает подключение к базе данных
        /// </summary>
        public static void Connection()
        {
            connection = new OleDbConnection(connectString);
            connection.Open();
            connectionSuccessful = true;
        }
        /// <summary>
        /// Закрывает подключение к базе данных
        /// </summary>
        public static void CloseConnection()
        {
            connection.Close();
            connectionSuccessful = false;
        }
        /// <summary>
        /// Возвращает есть ли подключние к базе данных
        /// </summary>
        public static bool ConnectionSuccessful
        { get { return connectionSuccessful; } }
        /// <summary>
        /// Проверяет пользователя в базе данных 
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <param name="password">Пароль пользователя</param>
        /// <returns></returns>
        public static AccessLevel CheckUser(string login, string password)
        {
            try
            {

                string query = "select Права_доступа from Пользователи where Логин_пользователя = '" + login + "' and Пароль_пользователя = '" + password + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                string result = command.ExecuteScalar().ToString();
                if (result == "1")
                    return AccessLevel.administator;
                else if (result == "2")
                    return AccessLevel.user;
                else if (result == "3")
                    return AccessLevel.guest;
                else
                    return AccessLevel.none;
            }
            catch (Exception)
            {
                return AccessLevel.none;
            }
        }
        /// <summary>
        /// Возвращает список городов из базы данных
        /// </summary>
        /// <returns>Список городов с их числовыми идентификаторами</returns>
        public static List<string[]> GetCities()
        {
            string query = "select * from Города";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader result = command.ExecuteReader();
            List<string[]> cities = new List<string[]>();
            while (result.Read())
                cities.Add(new string[2] { result["Код_города"].ToString(), result["Название_города"].ToString() });
            result.Close();
            return cities;
        }
        /// <summary>
        /// Возвращает список поездов для отображения на главной форме
        /// </summary>
        /// <returns>Список поездов</returns>
        public static List<string[]> GetTrains()
        {
            string query = "select Номер_поезда, Маршрут, Число_свободных_мест, Дата_отправления from Поезда " +
                "left join Маршруты on Поезда.Номер_маршрута = Маршруты.Номер_маршрута";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader result = command.ExecuteReader();
            List<string[]> trains = new List<string[]>();
            while (result.Read())
                trains.Add(new string[4] { result[0].ToString(), result[1].ToString(), result[2].ToString(), result[3].ToString() });
            result.Close();
            CreateFullRoutes(ref trains);
            FindTrains(ref trains);
            return trains;
        }
        /// <summary>
        /// Находит поезда соответствующие локации пользователя
        /// </summary>
        /// <param name="trains">Список поездов</param>
        public static void FindTrains(ref List<string[]> trains)
        {
            List<string[]> result = new List<string[]>();
            for (int i = 0; i < trains.Count; i++)
                if (!trains[i][1].Contains(User.Location))
                    trains.RemoveAt(i);
        }
        /// <summary>
        /// Воссоздает маршрут поезда
        /// </summary>
        /// <param name="routes">Список маршрутов</param>
        public static void CreateFullRoutes(ref List<string[]> routes)
        {
            List<string[]> cities = GetCities();
            string[] route_points;
            string route = "";
            for (int i = 0; i < routes.Count; i++)
            {
                route = "";
                route_points = routes[i][1].Split('-');
                for (int j = 0; j < route_points.Length; j++)
                    for (int k = 0; k < cities.Count; k++)
                        if (cities[k][0] == route_points[j])
                        {
                            route += cities[k][1] + "-";
                            break;
                        }
                route = route.Remove(route.Length - 1);
                routes[i][1] = route;
            }
        }
        /// <summary>
        /// Поучить имена всех таблиц в базе данных
        /// </summary>
        /// <returns>Список таблиц</returns>
        public static List<string> GetNameTables()
        {
            List<string> tables = new List<string>();
            DataTable dataTable = connection.GetSchema("Tables", new[] { null, null, null, "TABLE" });
            tables.AddRange(from DataRow item in dataTable.Rows select item["TABLE_NAME"].ToString());
            return tables;
        }
        /// <summary>
        /// Получить всю таблицу из базы данных
        /// </summary>
        /// <param name="NameTable">Имя таблицы</param>
        /// <returns>Таблица</returns>
        public static DataSet GetTable(string NameTable)
        {
            string query = "select * from " + NameTable;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter result = new OleDbDataAdapter(command);
            DataSet dataSet = new DataSet();
            result.Fill(dataSet, NameTable);
            return dataSet;
        }
        /// <summary>
        /// Сортирует поезда по пункту прибытия и времени отправки
        /// </summary>
        /// <param name="trains">Список поездов</param>
        /// <param name="arrivalPoint">Пункт прибытия</param>
        /// <param name="dateTime">Дата отправки</param>
        /// <returns>Отсортированый список поездов</returns>
        public static List<string[]> SortTrains(List<string[]> trains, string arrivalPoint, DateTime dateTime)
        {
            for (int i = trains.Count - 1; i >= 0; i--)
                if (!trains[i][1].Contains(arrivalPoint) || trains[i][3] != dateTime.ToString())
                    trains.RemoveAt(i);
            return trains;
        }
        /// <summary>
        /// Сортирует поезда по пункту прибытия
        /// </summary>
        /// <param name="trains">Список поездов</param>
        /// <param name="arrivalPoint">Пункт прибытия</param>
        /// <returns>Отсортированный список поездов</returns>
        public static List<string[]> SortTrains(List<string[]> trains, string arrivalPoint)
        {
            for (int i = trains.Count - 1; i >= 0; i--)
                if (!trains[i][1].Contains(arrivalPoint))
                    trains.RemoveAt(i);
            return trains;
        }
        /// <summary>
        /// Сортирует поезда по дате отправки
        /// </summary>
        /// <param name="trains">Список поездов</param>
        /// <param name="dateTime">Время отправки</param>
        /// <returns>Отсортированный список поездов</returns>
        public static List<string[]> SortTrains(List<string[]> trains, DateTime dateTime)
        {
            for (int i = trains.Count - 1; i >= 0; i--)
                if (trains[i][3] != dateTime.ToString())
                    trains.RemoveAt(i);
            return trains;
        }
        /// <summary>
        /// Возвращает список покупателей из базы данных
        /// </summary>
        /// <returns>Список покупателей</returns>
        public static List<string> GetBuyers()
        {
            string query = "select Логин_пользователя from Пользователи where Права_доступа = 3";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader result = command.ExecuteReader();
            List<string> buyers = new List<string>();
            while (result.Read())
                buyers.Add(result[0].ToString());
            result.Close();
            return buyers;
        }
        /// <summary>
        /// Обновление базы данных после продажи билета
        /// </summary>
        /// <param name="train">Массив поездов</param>
        /// <param name="DeparturePoint">Пункт отправления</param>
        /// <param name="ArrivalPoint">Пункт прибытия</param>
        /// <returns>Возвращает удалось ли занести изменения в базу данных</returns>
        public static bool UpdateAfterSell(string[] train, string DeparturePoint, string ArrivalPoint)
        {
            bool successful = true;
            string[] route_pointes = train[1].Split('-');
            string[] arr_available_seats = train[2].Split('-');
            string available_seats = "";
            int start = -1, end = -1;
            for (int i = 0; i < route_pointes.Length; i++)
            {
                if (route_pointes[i] == ArrivalPoint)
                    end = i;
                else if (route_pointes[i] == DeparturePoint)
                    start = i;
                if (end != -1 && start != -1)
                    break;
            }
            if (start < end)
                for (int i = start; i < end; i++)
                {
                    if (int.Parse(arr_available_seats[i]) > 0)
                        arr_available_seats[i] = (int.Parse(arr_available_seats[i]) - 1).ToString();
                    else
                    {
                        successful = false;
                        break;
                    }
                }
            else
                for (int i = start; i > end; i--)
                {
                    if (int.Parse(arr_available_seats[i]) > 0)
                        arr_available_seats[i] = (int.Parse(arr_available_seats[i]) - 1).ToString();
                    else
                    {
                        successful = false;
                        break;
                    }
                }
            if (successful == true)
            {
                for (int i = 0; i < arr_available_seats.Length; i++)
                    available_seats += arr_available_seats[i] + "-";
                available_seats = available_seats.Remove(available_seats.Length - 1);
                string query = "update Поезда set Число_свободных_мест = '" + available_seats + "' where Номер_поезда = " + train[0];
                OleDbCommand command = new OleDbCommand(query, connection);
                command.ExecuteNonQuery();
                return successful;
            }
            else
                return successful;
        }
    }
}
