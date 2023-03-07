using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprokat.DataBase
{
    public class DBControl
    {
        private readonly string _connectionString;

        public MovieActions movieControl;
        public SeatActions seatControl;
        public SessionActions sessionControl;
        public TicketActions ticketControl;
        public ScheduleActions scheduleControl;
        public HallAction hallControl;
        public DBControl(string connectionString)
        {
            movieControl =new MovieActions( connectionString);
            seatControl = new SeatActions(connectionString);
            sessionControl = new SessionActions(connectionString);
            ticketControl = new TicketActions(connectionString);
            scheduleControl = new ScheduleActions(connectionString);
            hallControl = new HallAction(connectionString);
        }
    }
}
