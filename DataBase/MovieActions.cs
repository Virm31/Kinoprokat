using Kinoprokat.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kinoprokat.DataBase
{
    class MovieActions
    {
        private readonly string _connectionString;

        public MovieActions(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddMovie(string title, DateTime year, string genre, int duration, string description)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO movies (title, year, genre, duration, description) VALUES (@Title, @Year, @Genre, @Duration, @Description)", connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Genre", genre);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateMovie(int id, string title, DateTime year, string genre, int duration, string description)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE movies SET title = @Title, year = @Year, genre = @Genre, duration = @Duration, description = @Description WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Genre", genre);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Description", description);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMovie(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM movies WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM movies", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var movie = new Movie()
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Year = reader.GetDateTime(2),
                        Genre = reader.GetString(3),
                        Duration = reader.GetInt32(4),
                        Description = reader.GetString(5)
                    };

                    movies.Add(movie);
                }
            }

            return movies;
        }

        public Movie GetMovieById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM movies WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Movie()
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Year = reader.GetDateTime(2),
                        Genre = reader.GetString(3),
                        Duration = reader.GetInt32(4),
                        Description = reader.GetString(5)
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
