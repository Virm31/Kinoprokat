using Kinoprokat.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoprokat
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBControl db = new DBControl("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\maxza\\source\repos\\Kinoprokat\\DataBase\\Database1.mdf; Integrated Security = True");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
