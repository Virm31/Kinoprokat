using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Session
    {
        /// <summary>
        /// Id сеанса в бд
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id фильма который показывается на сеансе
        /// </summary>
        public int MovieId { get; set; }
        /// <summary>
        /// Id зала в котором показывается фильм
        /// </summary>
        public int HallId { get; set; }
        /// <summary>
        /// Дата и время начала сеанса
        /// </summary>
        public DateTime StartTime { get; set; }
    }
}
