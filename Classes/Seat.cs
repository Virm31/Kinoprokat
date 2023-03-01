using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Seat
    {
        /// <summary>
        /// Id места в бд
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id зала в котором находится место 
        /// </summary>
        public int HallId { get; set; }
        /// <summary>
        /// Ряд в котором находится место
        /// </summary>
        public int Row { get; set; }
        /// <summary>
        /// Номер места в ряду
        /// </summary>
        public int Number { get; set; }
    }
}
