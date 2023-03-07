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
using Kinoprokat.DataBase;

namespace Kinoprokat
{
    public partial class SessionsEditor : Form
    {
        DBControl DB;
        public Form1 MainForm { get; internal set; }

        public SessionsEditor(DBControl db)
        {
            DB= db;
           
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (filmTitle.Text == string.Empty
                && filmYear.Text == string.Empty
                && filmGenre.Text == string.Empty
                && filmDuration.Text == string.Empty
                && filmDesc.Text == string.Empty)
            {
                //Не все поля заполнены
                MessageBox.Show("Ошибка! Невозможно выполнить операцию. Не все поля заполнены", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //var date = new DateTime();

            //if (!(DateTime.TryParseExact(filmYear.Text, "dd.MM.yyyy",
            //    CultureInfo.InvariantCulture, DateTimeStyles.None, out date)))
            //{
            //    MessageBox.Show("Ошибка! Невозможно выполнить операцию. Формат даты не dd.mm.yyyy",
            //        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            var time = 0;

            if (!(int.TryParse(filmDuration.Text, out time)))
            {
                MessageBox.Show("Ошибка! Невозможно выполнить операцию. Длительность не в минутах",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.movieControl.AddMovie(filmTitle.Text, filmYear.Value,
            filmGenre.Text, time, filmDesc.Text); 

            MainForm.FillFilmsTable();
            LoadFilmsID();
            LoadFilmsGenre();

            filmTitle.Text = string.Empty;
            filmYear.Text = string.Empty;
            filmGenre.Text = string.Empty;
            filmDuration.Text = string.Empty;
            filmDesc.Text = string.Empty;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DB.scheduleControl.DeleteScheduleByMovieId(Convert.ToInt32(RemoveIDList.Text));
            DB.movieControl.DeleteMovie(Convert.ToInt32(RemoveIDList.Text));
            MainForm.FillFilmsTable();
            LoadFilmsID();
            RemoveIDList.Text = "";
            MainForm.FillScheduleTable();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           //Хуй залупа
        }

        private void SessionsEditor_Load(object sender, EventArgs e)
        {
            LoadFilmsID();
            LoadFilmsGenre();
        }

        private void LoadFilmsID()
        {
            RemoveIDList.Items.Clear();
            var movies = DB.movieControl.GetMovies();

            foreach (var movie in movies)
            {

                RemoveIDList.Items.Add(movie.Id);
            }
        }

        private void LoadFilmsGenre()
        {
            filmGenre.Items.Clear();
            string[] genres = {"Боевик", "Вестерн", "Детектив", "Драма", "Исторический",
                "Комедия", "Мелодрама", "Мьюзикл", "Политический", "Приключение", "Сказка",
                "Мультфильм", "Трагедия", "Триллер", "Фантастика", "Ужас",};
           
            foreach (var genre in genres)
            {
                filmGenre.Items.Add(genre);
            }
        }

        private void filmDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
