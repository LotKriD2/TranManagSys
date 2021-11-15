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
    }
}
