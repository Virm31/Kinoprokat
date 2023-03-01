using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kinoprokat.Classes;

namespace Kinoprokat.DataBase
{
    class TicketActions
    {
        private readonly string _connectionString;

        public TicketActions(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddTickets(int session_id,  int seat_id, int price)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO tickets (session_id, seat_id, price) VALUES (@SessionId, @SeatId, @Price)", connection);
                command.Parameters.AddWithValue("@SessionId", session_id);
                command.Parameters.AddWithValue("@SeatId", seat_id);
                command.Parameters.AddWithValue("@Price", price);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateTicket(int id, int session_id, int seat_id, int price)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE tickets SET session_id = @SessionId, seat_id = @SeatId, price = @Price WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@SessionId", session_id);
                command.Parameters.AddWithValue("@SeatId", seat_id);
                command.Parameters.AddWithValue("@Price", price);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteTicket(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM tickets WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Ticket> GetTickets()
        {
            var tickets = new List<Ticket>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM tickets", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var ticket = new Ticket()
                    {
                        Id = reader.GetInt32(0),
                        SessionId= reader.GetInt32(1),
                        SeatId= reader.GetInt32(2),
                        Price= reader.GetInt32(3)
                    };

                    tickets.Add(ticket);
                }
            }

            return tickets;
        }

        public Ticket GetTicketById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM tickets WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Ticket()
                    {
                        Id = reader.GetInt32(0),
                        SessionId = reader.GetInt32(1),
                        SeatId = reader.GetInt32(2),
                        Price = reader.GetInt32(3)
                    };
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
