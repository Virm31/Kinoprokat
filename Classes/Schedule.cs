using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Schedule
    {
        /// <summary>
        /// Порядковый номер сеанса в расписании
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id фильма
        /// </summary>
        public int MovieId { get; set; }
        /// <summary>
        /// Время начала сеанса
        /// </summary>
        public DateTime Time { get; set; }
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
