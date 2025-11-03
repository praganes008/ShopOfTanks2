using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOfTanks
{
    public static class SQL_class
    {
        //функция подключения к Базе Данных
        public const string CONNECTION_STRING =
        "SslMode=none;Server=localhost;Database=shotbase;port=3306;Uid=root;charset=utf8";//строка подключения

        public static MySqlConnection CONN;

        public static List<string> mySelect(string cmdText)
        {
            List<string> list = new List<string>();
            MySqlCommand command = new MySqlCommand(cmdText, CONN);
            DbDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    list.Add(dr.GetValue(i).ToString());
                }
            }
            dr.Close();
            return list;
        }



    }

    
}
