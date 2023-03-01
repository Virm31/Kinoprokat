using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Ticket
    {
        /// <summary>
        /// Id билета в бд
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id сеанса к которому относится билет
        /// </summary>
        public int SessionId { get; set; }
        /// <summary>
        /// Id места нк которому относится билет
        /// </summary>
        public int SeatId { get; set; }
        /// <summary>
        /// Цена билета
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Продан ли билет
        /// </summary>
        public bool Sold { get; set; }

    }
}
