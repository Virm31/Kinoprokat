using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CinemaApp
{
    public class CinemaDatabase
    {
        private readonly string _connectionString;

        public CinemaDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddMovie(string title, string description, int duration, string posterUrl)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO movies (title, description, duration, poster_url) VALUES (@Title, @Description, @Duration, @PosterUrl)", connection);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@PosterUrl", posterUrl);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateMovie(int id, string title, string description, int duration, string posterUrl)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE movies SET title = @Title, description = @Description, duration = @Duration, poster_url = @PosterUrl WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@PosterUrl", posterUrl);
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
                        Description = reader.GetString(2),
                        Duration = reader.GetInt32(3),
                        PosterUrl = reader.GetString(4)
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
                        Description = reader.GetString(2),
                        Duration = reader.GetInt32(3),
                        PosterUrl = reader.GetString(4)
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        // Добавьте методы для работы с таблицами halls, sessions и seats аналогично
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string PosterUrl { get; set; }
    }
}