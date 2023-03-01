using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Movie
    {
        /// <summary>
        /// Id фильма в бд
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Дата выхода в прокат
        /// </summary>
        public DateTime Year { get; set; }
        /// <summary>
        /// Жанр
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Длительность в минутах
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Описание фильма
        /// </summary>
        public string Description { get; set; }
    }
}
