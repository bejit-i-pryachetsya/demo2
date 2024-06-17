using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace demo2
{
    internal class DB
    {

        NpgsqlConnection connection = new NpgsqlConnection("User ID = postgres; password = 12345; Host = localhost; Port = 5432; Database = demo2;");

        public void SetUser (string username, string tel_num, string password)
        {
            connection.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand($"Insert Into usser Values (DEFAULT, DEFAULT, '{username}', '{tel_num}', '{password}')", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable GetUser (string tel_num, string password)
        {
            DataTable dataTable= new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"select * from usser where tel_num = '{tel_num}' and passwordd = '{password}';", connection);
            adapter.Fill(dataTable);
            return dataTable;

        }


        public void SetZakaz(string userid, string telephone, string status, string date, string information, string type, string user_tel)
        {
            connection.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand($"Insert Into zakaz Values (DEFAULT, '{userid}', '{telephone}', '{status}', '{date}', '{information}', '{type}', '{user_tel}')", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }


        public DataTable GetZakaz()
        {
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"select * from zakaz;", connection);
            adapter.Fill(dataTable);
            return dataTable;

        }


    }
}
