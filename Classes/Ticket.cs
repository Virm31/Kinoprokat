using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.Classes
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SeatId { get; set; }
        public int Price { get; set; }
        public bool Sold { get; set; }

    }
}
