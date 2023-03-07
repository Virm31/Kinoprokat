using Kinoprokat.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoprokat
{
    
    public partial class Form1 : Form
    {

        DBControl DB;
        DataTable dt1;
        DataTable dt2;
        DataTable dt3;
        DataTable filmsTable;
        DataTable sessionsTable;
        DataTable scheduleTable;
        string[,] data1;
        string[,] data2;
        string[,] data3;
        string[,] filmsData;
        string[,] sessionsData;
        string[,] scheduleData;
        public Form1(DBControl db)
        {
            DB = db;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] columnNames1 = { "Фильм", "Дата релиза", "Неделя проката", "Зрители", 
                "Сборы", "Сеансы", "Средняя стоимость билетов" };
            dt1 = CreateDataTable(columnNames1);

            
            
            string[,] data1 = {
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
                { "Фильм 1", new DateTime(2023, 3, 1).ToString(), "1", "100", "1500", "10", "150" },
                { "Фильм 2", new DateTime(2023, 3, 8).ToString(), "2", "200", "3000", "20", "180" },
                { "Фильм 3", new DateTime(2023, 3, 15).ToString(), "3", "150", "2000", "15", "170" },
            };

            AddDataToDataTable(dt1, data1);
            dataGridView1.DataSource = dt1;

            // создаем вторую таблицу
            string[] columnNames2 = { "Фильм", "Количество сеансов", "Доля сеансов", 
                "Доля кассовых сборов" };
            dt2 = CreateDataTable(columnNames2);

            string[,] data2 = {
                { "Фильм 1", "10", "20%", "30%" },
                { "Фильм 2", "20", "40%", "50%" },
                { "Фильм 3", "15", "30%", "20%" },
                { "Фильм 1", "10", "20%", "30%" },
                { "Фильм 2", "20", "40%", "50%" },
                { "Фильм 3", "15", "30%", "20%" },
                { "Фильм 1", "10", "20%", "30%" },
                { "Фильм 2", "20", "40%", "50%" },
                { "Фильм 3", "15", "30%", "20%" },
                { "Фильм 1", "10", "20%", "30%" },
                { "Фильм 2", "20", "40%", "50%" },
                { "Фильм 1", "10", "20%", "30%" },
                { "Фильм 2", "20", "40%", "50%" },
                { "Фильм 3", "15", "30%", "20%" },
                { "Фильм 3", "15", "30%", "20%" },
            };

            AddDataToDataTable(dt2, data2);

            // создаем третью таблицу
            string[] columnNames3 = { "Фильм", "Активная покупка", "Неактивная покупка", 
                "Средняя заполняемость зала", "Средняя цена билета" };
            dt3 = CreateDataTable(columnNames3);

            string[,] data3 = {
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },
                { "Фильм 1", "50%", "50%", "70%", "120" },
                { "Фильм 2", "40%", "60%", "80%", "150" },
                { "Фильм 3", "30%", "70%", "90%", "130" },

            };
            AddDataToDataTable(dt3, data3);

            FillFilmsTable();
            FillScheduleTable();
            FillSessionsTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dt3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt1;
        }

        private DataTable CreateDataTable(string[] columnNames)
        {
            // создаем DataTable и добавляем столбцы в DataTable
            DataTable dt = new DataTable();

            foreach (string columnName in columnNames)
            {
                dt.Columns.Add(columnName, typeof(string));
            }

            return dt;
        }

        private void AddDataToDataTable(DataTable dt, string[,] data)
        {
            // добавляем строки в DataTable
            for (int i = 0; i < data.GetLength(0); i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row[j] = data[i, j];
                }
                dt.Rows.Add(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // обновляем данные в первой таблице
            AddDataToDataTable(dt1, data1);

            // обновляем данные во второй таблице
            AddDataToDataTable(dt2, data2);

            // обновляем данные в третьей таблице        
            AddDataToDataTable(dt3, data3);

            dataGridView1.DataSource = dt1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new ScheduleEditor(DB);
            form.MainForm = this;
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form = new MovieEditor(DB);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new SessionsEditor(DB);
            form.MainForm = this;
            form.Show();
        }

        public void FillFilmsTable()
        {
            string[] filmsTableColumns = { "Фильм", "Дата релиза", "Жанр",
                "Описание", "Продолжительность" };

            List<Classes.Movie> movies = DB.movieControl.GetMovies();

            filmsData = new string[movies.Count, 5];

            for (int i = 0; i < movies.Count; i++)
            {
                int j = 0;
                filmsData[i, j++] = movies[i].Title;
                filmsData[i, j++] = movies[i].Year.ToString("dd.MM.yyyy");
                filmsData[i, j++] = movies[i].Genre;
                filmsData[i, j++] = movies[i].Description;
                filmsData[i, j++] = movies[i].Duration.ToString() + " мин";
                j = 0;
            }

            filmsTable = CreateDataTable(filmsTableColumns);
            AddDataToDataTable(filmsTable, filmsData);
            dataGridView3.DataSource = filmsTable;
        }

        public void FillScheduleTable()
        {
            string[] scheduleTableColumns = { "Фильм", "Начало", "Продолжительность",
                "Описание" };

            List<Classes.Schedule> schedule = DB.scheduleControl.GetSchedule();

            scheduleData = new string[schedule.Count, 4];

            for (int i = 0; i < schedule.Count; i++)
            {
                int j = 0;
                scheduleData[i, j++] = DB.movieControl.GetMovieById(schedule[i].MovieId).Title;
                scheduleData[i, j++] = schedule[i].Time.ToShortTimeString();
                scheduleData[i, j++] = schedule[i].Duration.ToString() + " мин";
                scheduleData[i, j++] = schedule[i].Description;
                j = 0;
            }

            scheduleTable = CreateDataTable(scheduleTableColumns);
            AddDataToDataTable(scheduleTable, scheduleData);
            dataGridView2.DataSource = scheduleTable;
        }

        public void FillSessionsTable()
        {
            string[] sessionsTableColumns = { "Фильм", "Зал", "Время начала" };

            List<Classes.Session> sessions = DB.sessionControl.GetSessions();

            sessionsData = new string[sessions.Count, 3];

            for (int i = 0; i < sessions.Count; i++)
            {
                int j = 0;
                sessionsData[i, j++] = DB.movieControl.GetMovieById(sessions[i].MovieId).Title;
                sessionsData[i, j++] = DB.hallControl.GetHallById(sessions[i].HallId).Name;
                sessionsData[i, j++] = DB.scheduleControl.GetScheduleByMovieId(sessions[i].MovieId).
                    Time.ToString("hh:mm");
                j = 0;
            }

            sessionsTable = CreateDataTable(sessionsTableColumns);
            AddDataToDataTable(sessionsTable, sessionsData);
            dataGridView4.DataSource = sessionsTable;
        }
    }
}
