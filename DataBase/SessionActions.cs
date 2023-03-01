using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Kinoprokat.Classes;

namespace Kinoprokat.DataBase
{
    public class SessionActions
    {
        private readonly string _connectionString;

        public SessionActions(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddSession(int movie_id, int hall_id, DateTime start_time)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO sessions (movie_id, hall_id, start_time) VALUES (@MovieId, @HallId, @StartTime)", connection);
                command.Parameters.AddWithValue("@MovieId", movie_id);
                command.Parameters.AddWithValue("@HallId", hall_id);
                command.Parameters.AddWithValue("@StartTime", start_time);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateSession(int id, int movie_id, int hall_id, DateTime start_time)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE sessions SET movie_id = @MovieId, hall_id = @HallId, start_time = @StartTime WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@MovieId", movie_id);
                command.Parameters.AddWithValue("@HallId", hall_id);
                command.Parameters.AddWithValue("@StartTime", start_time);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteSession(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM sessions WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Session> GetSessions()
        {
            var sessions = new List<Session>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM sessions", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var session = new Session()
                    {
                        Id = reader.GetInt32(0),
                        MovieId= reader.GetInt32(1),
                        HallId= reader.GetInt32(2),
                        StartTime= reader.GetDateTime(3)
                    };

                    sessions.Add(session);
                }
            }

            return sessions;
        }

        public Session GetSessionById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM sessions WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Session()
                    {
                        Id = reader.GetInt32(0),
                        MovieId = reader.GetInt32(1),
                        HallId = reader.GetInt32(2),
                        StartTime = reader.GetDateTime(3)
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
