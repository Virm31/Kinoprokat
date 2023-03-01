using Kinoprokat.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Kinoprokat.DataBase
{
    public class HallAction
    {
        private readonly string _connectionString;

        public HallAction(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Добавить зал в общий пул
        /// </summary>
        /// <param name="name">Название зала</param>
        /// <param name="capacity">Вместимость</param>
        /// <param name="screen_type">Тип экрана</param>
        public void AddHall(string name, int capacity, string screen_type)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("INSERT INTO halls (name, capacity, screen_type) VALUES (@Name, @Capacity, @ScreenType)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Capacity", capacity);
                command.Parameters.AddWithValue("@ScreenType", screen_type);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Обновить информацию по конкретному залу
        /// </summary>
        /// <param name="id">Id зала</param>
        /// <param name="name">Новое имя зала</param>
        /// <param name="capacity">Новая вместимость зала</param>
        /// <param name="screen_type">Новый тип зала</param>
        public void UpdateHall(int id, string name, int capacity, string screen_type)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("UPDATE halls SET name = @Name, capacity = @Capacity, screen_type = @ScreenType WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Capacity", capacity);
                command.Parameters.AddWithValue("@ScreenType", screen_type);

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Удалить кинозал по индексу
        /// </summary>
        /// <param name="id">Id зала</param>
        public void DeleteHall(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("DELETE FROM halls WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Получить список всех кинозалов
        /// </summary>
        /// <returns>Коллекция кинозалов</returns>
        public List<Hall> GetHalls()
        {
            var halls = new List<Hall>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM halls", connection);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var hall = new Hall()
                    {
                        Id = reader.GetInt32(0),
                        Name= reader.GetString(1),
                        Capacity= reader.GetInt32(2),
                        ScreenType= reader.GetString(3)
                    };

                    halls.Add(hall);
                }
            }

            return halls;
        }

        /// <summary>
        /// Получить кинозал по индексу
        /// </summary>
        /// <param name="id">Id зала</param>
        /// <returns>Экземпляр кинозала</returns>
        public Hall GetHallById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM halls WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Hall()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Capacity = reader.GetInt32(2),
                        ScreenType = reader.GetString(3)
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
