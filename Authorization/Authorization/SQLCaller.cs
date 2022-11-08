using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Authorization
{
    internal class SQLCaller
    {
        private MySqlConnection connection = new MySqlConnection("" +
            "server=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=;" +
            "database=loginpassworddb");

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public bool checkUser(String login, String password)
        {
            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` " +
                "WHERE `login` = @userlogin AND `password` = @userpassword;", connection);
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = password;

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool checkUser(string login)
        {
            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` " +
                "WHERE `login` = @userlogin", connection);
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = login;

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool addUser(string login, string password)
        {
            //INSERT INTO `table` (`id`, `login`, `password`) VALUES (NULL, 'firstuser', 'Password123');

            if (checkUser(login)) //если в DB уже есть кто-то с таким логином
            {
                return false;
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) " +
                "VALUES ('" + login + "', '" + password + "')", connection);

                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
