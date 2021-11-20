

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DbConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = getMovies();

            foreach (var movie in movies)
            {
                Console.WriteLine($"- {movie.Name}");
                Console.WriteLine($"   Year: {movie.Year}");
                Console.WriteLine($"   Description    {movie.Description}");
            }
        }

        private static IEnumerable<Movie> getMovies()
        {
            string connectionString =
                "Server=localhost;Database=Imdb;User Id=sa;Password=SignalTest123;";

            var queryWhere = Console.ReadLine();

            var movies = new List<Movie>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var query = $"select * from Movies {queryWhere}";

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            var movie = new Movie();
                            movie.Name = sdr["Name"].ToString();
                            movie.Description = sdr["Description"].ToString();
                            movie.Year = int.Parse(sdr["Year"].ToString());

                            movies.Add(movie);
                        }
                    }

                    con.Close();

                }

            }

            return movies;
        }
    }
}
