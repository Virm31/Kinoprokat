using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        DataTable dt1;
        DataTable dt2;
        DataTable dt3;
        DataTable dt4;
        string[,] data1;
        string[,] data2;
        string[,] data3;
        string[,] data4;
        public Form1()
        {
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

            string[] columnNames4 = { "Фильм", "Время начала сеанса", "Длительность",
                "Цена", "Куплено билетов", "Осталось билетов"};
            dt4 = CreateDataTable(columnNames4);
            string[,] data4 = {
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
                { "Фильм 1", "14:00", "2:50", "300", "120", "50"},
            };
            AddDataToDataTable(dt4, data4);
            dataGridView2.DataSource = dt4;


            dataGridView3.DataSource = dt4;

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

        //public class Movie
        //{
        //    public string Title { get; set; } // Название фильма
        //    public int Duration { get; set; } // Длительность фильма в минутах
        //    public int Price { get; set; } // Цена билета на фильм

        //    public Movie(string title, int duration, int price)
        //    {
        //        Title = title;
        //        Duration = duration;
        //        Price = price;
        //    }
        //}

        //public class MovieSchedule
        //{
        //    public Movie Movie { get; set; } // Фильм, который будет показываться на сеансе
        //    public string StartTime { get; set; } // Время начала сеанса

        //    public MovieSchedule(Movie movie, DateTime startTime, DateTime endTime)
        //    {
        //        Movie = movie;
        //        StartTime = startTime;
        //        EndTime = endTime;
        //    }
        //}

        //public List<MovieSchedule> GenerateShowtimes(List<Movie> movies, TimeSpan startTime, TimeSpan endTime, TimeSpan interval)
        //{
        //    var schedules = new List<MovieSchedule>();

        //    foreach (var movie in movies)
        //    {
        //        // Создание расписания для каждого дня недели
        //        for (int i = 0; i < 7; i++)
        //        {
        //            var currentDate = DateTime.Today.AddDays(i);
        //            var currentTime = currentDate + startTime;

        //            // Создание расписания сеансов для каждого фильма на конкретный день
        //            while (currentTime <= currentDate + endTime)
        //            {
        //                schedules.Add(new MovieSchedule(movie, currentTime, currentTime + movie.Duration));
        //                currentTime += interval;
        //            }
        //        }
        //    }

        //    return schedules;
        //}


        //public static Dictionary<DayOfWeek, List<MovieSchedule>> GenerateSchedule(List<Movie> movies)
        //{
        //    var scheduleByDayOfWeek = new Dictionary<DayOfWeek, List<MovieSchedule>>();

        //    // генерируем расписание для каждого дня недели
        //    foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
        //    {
        //        var movieSchedules = new List<MovieSchedule>();

        //        // генерируем расписание для каждого фильма
        //        foreach (var movie in movies)
        //        {
        //            var showtimes = GenerateShowtimes(dayOfWeek, movie.Duration);

        //            if (showtimes.Count > 0)
        //            {
        //                var movieSchedule = new MovieSchedule(movie, showtimes);
        //                movieSchedules.Add(movieSchedule);
        //            }
        //        }

        //        scheduleByDayOfWeek[dayOfWeek] = movieSchedules;
        //    }

        //    return scheduleByDayOfWeek;
        //}

        //// метод для заполнения ComboBox фильмами
        //private void PopulateMovieComboBox()
        //{
        //    // очищаем ComboBox и добавляем все фильмы из movies в него
        //    comboBoxMovies.Items.Clear();
        //    foreach (var movie in movies)
        //    {
        //        comboBoxMovies.Items.Add(movie);
        //    }
        //}

        //// метод для обновления расписания в DataGridView
        //private void UpdateSchedule()
        //{
        //    // получаем выбранный день недели из ComboBox
        //    DayOfWeek dayOfWeek = (DayOfWeek)comboBoxDayOfWeek.SelectedItem;

        //    // получаем выбранный фильм из ComboBox
        //    Movie selectedMovie = (Movie)comboBoxMovies.SelectedItem;

        //    // генерируем расписание сеансов для выбранного дня недели
        //    var schedule = GenerateSchedule(movies)[dayOfWeek];

        //    // если выбран фильм, фильтруем расписание по фильму
        //    if (selectedMovie != null)
        //    {
        //        schedule = schedule.Where(ms => ms.Movie == selectedMovie).ToList();
        //    }

        //    // заполняем DataGridView расписанием сеансов
        //    dataGridViewSchedule.Rows.Clear();
        //    foreach (var movieSchedule in schedule)
        //    {
        //        var row = new DataGridViewRow();
        //        row.CreateCells(dataGridViewSchedule);
        //        row.Cells[0].Value = movieSchedule.Movie.Title;
        //        row.Cells[1].Value = string.Join(", ", movieSchedule.Showtimes.Select(st => st.ToString("hh:mm tt")));
        //        dataGridViewSchedule.Rows.Add(row);
        //    }
        //}

    }
}
