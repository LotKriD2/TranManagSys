using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TranManagSysLibrary.DBConnection;

namespace TranManagSysLibrary
{
    /// <summary>
    /// Перечисление уровней доступа
    /// </summary>
    public enum AccessLevel
    {
        administator, user, guest, none
    }
    /// <summary>
    /// Класс для хранения информации о текущем пользователе
    /// </summary>
    public static class User
    {
        //Логин пользователя
        static string login;
        //Пароль пользователя
        static string password;
        //Уровень доступа пользователя
        static AccessLevel accessLevel;
        //Локация пользователя
        static string location;
        static bool authorizationSuccessful = false;
        /// <summary>
        /// Проводит авторизацию пользователя
        /// </summary>
        /// <param name="input_login">Введенный логин</param>
        /// <param name="input_password">Введенный пароль</param>
        /// <param name="city">Город входа</param>
        public static void Athorization(string input_login, string input_password, string city)
        {
            login = input_login;
            password = input_password;
            location = city;
            if (!ConnectionSuccessful)
                Connection();
            accessLevel = CheckUser(login, password);
            authorizationSuccessful = true;
        }
        /// <summary>
        /// Возвращает логин пользователя
        /// </summary>
        public static string Login
        { get { return login; } }
        /// <summary>
        /// Возвращает уровень лоступа пользователя
        /// </summary>
        public static AccessLevel AccessLevel
        { get { return accessLevel; } }
        /// <summary>
        /// Возвращает локацию пользователя
        /// </summary>
        public static string Location
        { get { return location; } }
        /// <summary>
        /// Возвращает уалась ли авторизация пользователя
        /// </summary>
        public static bool AuthorizationSuccessful
        { get { return authorizationSuccessful; } }
    }
}
