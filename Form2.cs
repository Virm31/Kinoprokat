using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kinoprokat.DataBase;
using Kinoprokat.Classes;
using System.Globalization;

namespace Kinoprokat
{
    public partial class ScheduleEditor : Form
    {
        DBControl DB;
        int currentTime = 9 * 60;
        int timeOut = 20;
        int endTime = 24 * 60 + 2 * 60;
        public Form1 MainForm { get; internal set; }

        string[] defaultTime = { "09:00", "10:00", "11:00", "12:00", "13:00", "14:00",
                "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00",
                "23:00", "00:00", "01:00" };

        public ScheduleEditor(DBControl db)
        {
            DB = db;
 
            InitializeComponent();
        }

        private void checkAddIdButton_Click(object sender, EventArgs e)
        {
           
        }

        private int TimeToMinutes(string time)
        {
            int hours = int.Parse(time.Substring(0, 2));
            int minutes = int.Parse(time.Substring(3, 2));

            if (hours == 0) { hours = 24; }
            if (hours == 1) { hours = 25; }
            if (hours == 2) { hours = 26; }

            return hours * 60 + minutes;
        }

        private string MinutesToTime(int minutes)
        {
            return Math.Truncate((decimal)minutes / 60).ToString() + ":"
                + (minutes % 60).ToString();
        }

        private int TimeNormalize(int time)
        {
            while (time % 5 != 0)
            {
                time++;
            }

            return time;
        }

        private void AddFilmButton_Click(object sender, EventArgs e)
        {

            if(AddFilmsInput.Text == string.Empty)
            {
                MessageBox.Show("Ошибка! Невозможно выполнить операцию. Не выбран фильм",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (freeTime.Text == string.Empty)
            {
                MessageBox.Show("Ошибка! Невозможно выполнить операцию. Начало фильма не выбрано",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var movie = DB.movieControl.GetMovieById(Convert.ToInt32(AddFilmsInput.Text));

            if((TimeToMinutes(freeTime.Text) + movie.Duration + timeOut) > endTime)
            {
                MessageBox.Show("Ошибка! Невозможно выполнить операцию. Начало фильма слишком поздно",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.WriteLine((TimeToMinutes(freeTime.Text).ToString()));

            DB.scheduleControl.AddSchedule(movie.Id, 
                DateTime.ParseExact(freeTime.Text, "HH:mm", CultureInfo.InvariantCulture),
                movie.Duration, movie.Description);

            LoadAvailableStartTime(freeTime.Text, movie.Duration);
            MainForm.FillScheduleTable();
            MainForm.FillSessionsTable();
            OldFilmsList.Items.Clear();
            LoadSchedules();
        }

        private void checkRemoveIdButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RemoveFilmButton_Click(object sender, EventArgs e)
        {
            var movie = DB.movieControl.GetMovieById(Convert.ToInt32(RemoveIdInput.Text));
            DB.scheduleControl.DeleteScheduleByMovieId(movie.Id);
            MainForm.FillScheduleTable();
            OldFilmsList.Items.Clear();
            LoadSchedules();;
        }

        private void RightMoveButton_Click(object sender, EventArgs e)
        {
            var value = (string)OldFilmsList.SelectedItem;
            NewFilmsList.Items.Add(value);
            OldFilmsList.Items.Remove(value);
        }

        private void LeftMoveButton_Click(object sender, EventArgs e)
        {
            var value = (string)NewFilmsList.SelectedItem;
            NewFilmsList.Items.Remove(value);
            OldFilmsList.Items.Add(value);
        }

        private void LoadSchedules()
        {
            foreach (var movie in DB.scheduleControl.GetSchedule())
            {
                OldFilmsList.Items.Add(DB.movieControl.GetMovieById(movie.MovieId).Title);
            }
        }

        private void SaveSeqButton_Click(object sender, EventArgs e)
        {
            foreach(var item in NewFilmsList.Items)
            {
                var movies = DB.movieControl.GetMovies();
                int movieId = 0;

                foreach (var movie in movies)
                {
                    if (movie.Title == item.ToString())
                    {
                        movieId = movie.Id;
                    }
                }

                var schedule = DB.scheduleControl.GetScheduleByMovieId(movieId);
                DB.scheduleControl.DeleteSchedule(schedule.Id);
                DB.scheduleControl.AddSchedule(schedule.MovieId, schedule.Time,
                    schedule.Duration, schedule.Description);
            }

            MainForm.FillScheduleTable();
            LoadSchedules();
            NewFilmsList.Items.Clear();
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {
            LoadFilmsID();
            LoadAvailableStartTime();
            LoadSchedules();
        }

        private void LoadFilmsID()
        {
            AddFilmsInput.Items.Clear();
            RemoveIdInput.Items.Clear();
            var movies = DB.movieControl.GetMovies();

            foreach (var movie in movies)
            {
                RemoveIdInput.Items.Add(movie.Id);
                AddFilmsInput.Items.Add(movie.Id);
            }
        }

        private void LoadAvailableStartTime(string start, int duration)
        {
            freeTime.Items.Clear();

            var currentTime = TimeNormalize(TimeToMinutes(start) + duration + timeOut);
            var cutIndex = 0;
            for (int i = 0; i < defaultTime.Length; i++)
            {
                if(currentTime > TimeToMinutes(defaultTime[i]))
                {
                    cutIndex = i + 1;
                }
                else
                {
                    i = defaultTime.Length;
                }
            }

            int elementsToDelete = defaultTime.Length - cutIndex;

            string[] newTimes = new string[elementsToDelete];

            for (int i = 0; i < elementsToDelete; i++)
            {
                newTimes[i] = defaultTime[i + cutIndex];
            }

            freeTime.Items.Add(MinutesToTime(currentTime));

            foreach (var time in newTimes)
            {
                freeTime.Items.Add(time);
            }
        }

        private void LoadAvailableStartTime()
        {
            freeTime.Items.Clear();

            foreach (var time in defaultTime)
            {
                freeTime.Items.Add(time);
            }
        }
    }
}
