using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranManagSysLibrary
{
    /// <summary>
    /// Класс, для хранения данных о выбранной таблице
    /// </summary>
    public class Data
    {
        //Имя текущей таблицы
        static string nameTable;
        //Поля текущей таблицы
        static List<string> nameColumns = new List<string>();
        //Значения выбранной записи текущей таблицы
        static List<string> valueColumns = new List<string>();
        //Идентификатор записи
        static int id;
        //Условие для запроса к базе данных
        static string condition;
        /// <summary>
        /// Возвращает или задает поля таблицы
        /// </summary>
        public static List<string> NameColumns
        { get { return nameColumns; } set { nameColumns = value; } }
        /// <summary>
        /// Возращает или задает идентификатор записи
        /// </summary>
        public static int ID
        { get { return id; } set { id = value; } }
        /// <summary>
        /// Возвращает или задает имя таблицы
        /// </summary>
        public static string NameTable
        { get { return nameTable; } set { nameTable = value; } }
        /// <summary>
        /// Возвращает или задает значения выбранной записи таблицы
        /// </summary>
        public static List<string> ValueColumns
        { get { return valueColumns; } set { valueColumns = value; } }
        /// <summary>
        /// Возвращает условие запроса к базе данных
        /// </summary>
        public static string Condition
        { get { return condition; } }
        /// <summary>
        /// Создает условие для запроса добавления
        /// </summary>
        public static void CreateConditionForAdd()
        {
            int n = 0;
            condition = "";
            string columns = "";
            string values = "";
            for (int i = 0; i < valueColumns.Count; i++)
            {
                if (i == 0)
                {
                    columns += "( " + nameColumns[i] + ", ";
                    if (int.TryParse(valueColumns[i], out n))
                        values += "( " + valueColumns[i] + ", ";
                    else
                        values += "( '" + valueColumns[i] + "', ";
                }
                else if (i == valueColumns.Count - 1)
                {
                    columns += nameColumns[i] + " )";
                    if (int.TryParse(valueColumns[i], out n))
                        values += valueColumns[i] + " )";
                    else
                        values += "'" + valueColumns[i] + "' )";
                }
                else
                {
                    columns += nameColumns[i] + ", ";
                    if (int.TryParse(valueColumns[i], out n))
                        values += valueColumns[i] + ", ";
                    else
                        values += "'" + valueColumns[i] + "', ";
                }
            }
            condition = columns + " values " + values;
        }
        /// <summary>
        /// Создает условие для запроса обновления
        /// </summary>
        public static void CreateConditionForUpdate()
        {
            int n = 0;
            condition = " where " + nameColumns[0] + " = " + valueColumns[0];
            string values = "";
            for (int i = 1; i < valueColumns.Count; i++)
            {
                if (i != valueColumns.Count - 1)
                {
                    if (int.TryParse(valueColumns[i], out n))
                        values += nameColumns[i] + " = " + valueColumns[i] + ", ";
                    else
                        values += nameColumns[i] + " = '" + valueColumns[i] + "', ";
                }
                else
                {
                    if (int.TryParse(valueColumns[i], out n))
                        values += nameColumns[i] + " = " + valueColumns[i];
                    else
                        values += nameColumns[i] + " = '" + valueColumns[i] + "'";
                }
            }
            condition = "set " + values + condition;
        }
    }
    /// <summary>
    /// Класс, для хранения нформации о вагонах
    /// </summary>
    public class Wagon
    {
        //Название вагона
        string name;
        //Идентификатор вагона
        int id;
        //Число мест в вагоне
        int numSeats;
        /// <summary>
        /// Конструктор класса Wagon
        /// </summary>
        /// <param name="id">Идентификатор вагона</param>
        /// <param name="name">Название вагона</param>
        /// <param name="numSeats">Число мест в вагоне</param>
        public Wagon(int id, string name, int numSeats)
        {
            this.id = id;
            this.name = name;
            this.numSeats = numSeats;
        }
        /// <summary>
        /// Возвращает назание вагона
        /// </summary>
        public string Name
        { get { return name; } }
        /// <summary>
        /// Возвращает идентификатор вагона
        /// </summary>
        public int ID
        { get { return id; } }
        /// <summary>
        /// Возвращает число мест в вагоне
        /// </summary>
        public int NumSeats
        { get { return numSeats; } }
        /// <summary>
        /// Переопределение метода преобразования в строку
        /// </summary>
        /// <returns>Преобразованный в строку объект</returns>
        public override string ToString()
        {
            return name;
        }
    }
    /// <summary>
    /// Класс, для хранения нформации о городах
    /// </summary>
    public class City
    {
        //Название города
        string name;
        //Идентификатор города
        int id;
        /// <summary>
        /// Конструктор класса City
        /// </summary>
        /// <param name="id">Идентификатор города</param>
        /// <param name="name">Название города</param>
        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        /// <summary>
        /// Возвращает название города
        /// </summary>
        public string Name
        { get { return name; } }
        /// <summary>
        /// Возвращает идентификатор города
        /// </summary>
        public int ID
        { get { return id; } }
        /// <summary>
        /// Переопределение метода преобразования в строку
        /// </summary>
        /// <returns>Преобразованный в строку объект</returns>
        public override string ToString()
        {
            return name;
        }
    }
}
