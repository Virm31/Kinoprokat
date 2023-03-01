using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kinoprokat.Classes;

namespace Kinoprokat.DataBase
{
    public class SeatActions
    {
        private readonly string _connectionString;

        public SeatActions(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddSeat(int hall_id , int row, int number)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO seats (hall_id, row, number) VALUES (@HallId, @Row, @Number)", connection);
                command.Parameters.AddWithValue("@HallId", hall_id);
                command.Parameters.AddWithValue("@Row", row);
                command.Parameters.AddWithValue("@Number", number);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateSeat(int id, int hall_id, int row, int number)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE seats SET hall_id= @HallId, row= @Row, number= @Number WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@HallId", hall_id);
                command.Parameters.AddWithValue("@Row", row);
                command.Parameters.AddWithValue("@Number", number);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteSeat(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM seats WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Seat> GetSeats()
        {
            var seats = new List<Seat>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM seats", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var seat = new Seat()
                    {
                        Id = reader.GetInt32(0),
                        HallId= reader.GetInt32(1),
                        Row= reader.GetInt32(2),
                        Number=reader.GetInt32(3)
                    };

                    seats.Add(seat);
                }
            }

            return seats;
        }

        public Seat GetSeatById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM seats WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Seat()
                    {
                        Id = reader.GetInt32(0),
                        HallId = reader.GetInt32(1),
                        Row = reader.GetInt32(2),
                        Number = reader.GetInt32(3)
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
