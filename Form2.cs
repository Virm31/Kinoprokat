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

namespace Kinoprokat
{
    public partial class ScheduleEditor : Form
    {
        DBControl DB;
        int currentTime = 9 * 60; //9 утра в минутах
        int timeOut = 20;//20 минут перерыва
        int endTime = 24 * 60 + 2 * 60;
        List<Schedule> schedules;
        List<Schedule> newSchedules;
        Dictionary<string, int> catalog;


        public ScheduleEditor(DBControl db)
        {
            DB = db;
            schedules = DB.scheduleControl.GetSchedule();
            LoadSchedules();
            InitializeComponent();
        }

        private void checkAddIdButton_Click(object sender, EventArgs e)
        {
            string[] defaultTime = { "9:00", "10:00", "11:00", "12:00", "13:00", "14:00",
                "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00",
                "23:00", "00:00", "01:00" };

            if (DB.movieControl.GetMovies().Contains
                (DB.movieControl.GetMovieById(Convert.ToInt32(AddIdInput.Text))))
            {
                if(DB.scheduleControl.GetSchedule().Count == 0)
                {
                    foreach(var time in defaultTime)
                    {
                        freeTime.Items.Add(time);
                    }
                }
                else //В данной версии не учитыватся, что вставляется куда попало поэтому крашнется
                {
                    freeTime.Items.Add(MinutesToTime(currentTime));
                    int nextTimesIndex = 0;

                    foreach (var time in defaultTime)
                    {
                        while(currentTime > TimeToMinutes(defaultTime[nextTimesIndex]))
                        {
                            nextTimesIndex++;
                        }
                        break;
                    }

                    while (nextTimesIndex < defaultTime.Length)
                    {
                        freeTime.Items.Add(defaultTime[nextTimesIndex]);
                        nextTimesIndex++;
                    }
                }
            }
            else
            {
                //Сообщить об отсутствии
            }
        }

        private int TimeToMinutes(string time)
        {
            string[] hoursAndMinutes = time.Split(':');
            return Convert.ToInt32(hoursAndMinutes[0], 10) * 60 + Convert.ToInt32(hoursAndMinutes[1]);
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
            var movie = DB.movieControl.GetMovieById(Convert.ToInt32(AddIdInput.Text));
            if (currentTime + movie.Duration < endTime)
            {
                DB.scheduleControl.AddSchedule(movie.Id, DateTime.ParseExact(freeTime.Text, "H:mm", null),
                    movie.Duration, movie.Description);

                schedules = DB.scheduleControl.GetSchedule();
                LoadSchedules();

                currentTime += movie.Duration + timeOut;
            }
            else
            {
                //Сообщить о выходе за пределы рабочего времени
            }

        }

        private void checkRemoveIdButton_Click(object sender, EventArgs e)
        {
            if (DB.movieControl.GetMovies().Contains
                (DB.movieControl.GetMovieById(Convert.ToInt32(RemoveIdInput.Text))))
            {
                //Сообщить об успехе
            }
            else
            {
                //Сообщить об отсутствии
            }
        }

        private void RemoveFilmButton_Click(object sender, EventArgs e)
        {
            var movie = DB.movieControl.GetMovieById(Convert.ToInt32(RemoveIdInput.Text));
            DB.scheduleControl.DeleteSchedule(movie.Id);
            schedules = DB.scheduleControl.GetSchedule();
            LoadSchedules();
        }

        private void RightMoveButton_Click(object sender, EventArgs e)
        {
            foreach (var item in OldFilmsList.SelectedItems)
            {
                OldFilmsList.Items.Add(item);
                NewFilmsList.Items.Remove(item);
            }
        }

        private void LeftMoveButton_Click(object sender, EventArgs e)
        {
            foreach (var item in NewFilmsList.SelectedItems)
            {
                NewFilmsList.Items.Add(item);
                OldFilmsList.Items.Remove(item);
            }
        }

        private void LoadSchedules()
        {
            foreach (var movie in schedules)
            {
                OldFilmsList.Items.Add(DB.movieControl.GetMovieById(movie.MovieId).Title);
                catalog.Add(DB.movieControl.GetMovieById(movie.MovieId).Title,
                    DB.movieControl.GetMovieById(movie.MovieId).Id);
            }
        }

        private void SaveSeqButton_Click(object sender, EventArgs e)
        {
            //заново добавить фильмы в шедул лист
        }
    }
}
