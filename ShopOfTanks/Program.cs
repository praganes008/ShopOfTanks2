using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopOfTanks
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQL_class.CONN = new MySqlConnection(SQL_class.CONNECTION_STRING);
            SQL_class.CONN.Open();

            Application.Run(new MainForm());

            SQL_class.CONN.Close();
        }
    }
}
