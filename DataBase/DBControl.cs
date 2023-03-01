using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.DataBase
{
    class DBControl
    {
        private readonly string _connectionString;

        MovieActions movieControl;
        SeatActions seatControl;
        SessionActions sessionControl;
        TicketActions ticketControl;

        public DBControl(string connectionString)
        {
            movieControl =new MovieActions( connectionString);
            seatControl = new SeatActions(connectionString);
            sessionControl = new SessionActions(connectionString);
            ticketControl = new TicketActions(connectionString);

        }
    }
}
