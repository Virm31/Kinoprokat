using Kinoprokat.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinoprokat.DataBase;

namespace Kinoprokat.DataBase
{ 
    public class ScheduleActions
    {
        private readonly string _connectionString;
        private DBControl DB;

        public ScheduleActions(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddSchedule(int movie_id, DateTime time, int duration, string description)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO schedule (movie_id, time, duration, description) VALUES (@MovieId, @Time, @Duration, @Description)", connection);
                command.Parameters.AddWithValue("@MovieId", movie_id);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateSchedule(int id, int movie_id, DateTime time, int duration, string description)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE schedule SET movie_id = @MovieId, time = @Time, duration = @Duration, description = @Description WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@MovieId", movie_id);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteSchedule(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM schedule WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Schedule> GetSchedule()
        {
            var schedules = new List<Schedule>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM schedule", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var schedule = new Schedule()
                    {
                        Id = reader.GetInt32(0),
                        MovieId= reader.GetInt32(1),
                        Time= reader.GetDateTime(2),
                        Duration = reader.GetInt32(3),
                        Description = reader.GetString(4)
                    };

                    schedules.Add(schedule);
                }
            }

            return schedules;
        }

        public Schedule GetScheduleById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM schedule WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Schedule()
                    {
                        Id = reader.GetInt32(0),
                        MovieId = reader.GetInt32(1),
                        Time = reader.GetDateTime(2),
                        Duration = reader.GetInt32(3),
                        Description = reader.GetString(4)
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public Schedule GetScheduleByMovieId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM schedule WHERE movie_id = @MovieId", connection);
                command.Parameters.AddWithValue("@MovieId", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Schedule()
                    {
                        Id = reader.GetInt32(0),
                        MovieId = reader.GetInt32(1),
                        Time = reader.GetDateTime(2),
                        Duration = reader.GetInt32(3),
                        Description = reader.GetString(4)
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public Schedule GetScheduleByMovieTitle(string title)
        {
            var movies = DB.movieControl.GetMovies();
            int movieId = 0;

            foreach(var movie in movies)
            {
                if (movie.Title == title)
                {
                    movieId = movie.Id;
                }
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM schedule WHERE movie_id = @MovieId", connection);
                command.Parameters.AddWithValue("@MovieId", movieId);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Schedule()
                    {
                        Id = reader.GetInt32(0),
                        MovieId = reader.GetInt32(1),
                        Time = reader.GetDateTime(2),
                        Duration = reader.GetInt32(3),
                        Description = reader.GetString(4)
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public void DeleteScheduleByMovieId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM schedule WHERE movie_id = @MovieId", connection);
                command.Parameters.AddWithValue("@MovieId", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
