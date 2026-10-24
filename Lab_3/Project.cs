using System;

namespace Lab3
{
    public enum Genre
    {
        Action = 1,
        Comedy,
        Drama,
        SciFi,
        Horror
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Genre MovieGenre { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }

        public Movie(int id, string title, int year, Genre genre, int views, int likes)
        {
            Id = id;
            Title = title;
            Year = year;
            MovieGenre = genre;
            Views = views;
            Likes = likes;
        }

        public double CalculateRating()
        {
            if (Views == 0) return 0.0;
            double val = (double)(Likes * Likes) / Views;
            return Math.Sqrt(val);
        }

        public override string ToString()
        {
            string idStr = Id.ToString().PadLeft(4);
            string titleStr = Title.PadRight(15);
            string yearStr = $"({Year})".PadRight(8);
            string genreStr = MovieGenre.ToString().PadRight(12);
            string ratingStr = CalculateRating().ToString("0.000").PadLeft(8);

            return $"{idStr} | {titleStr} | {yearStr} | {genreStr} | {ratingStr}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Movie[] movies = new Movie[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(',');

                int id = int.Parse(parts[0].Trim());
                string title = parts[1].Trim();
                int year = int.Parse(parts[2].Trim());
                int genreNum = int.Parse(parts[3].Trim());
                Genre genre = (Genre)genreNum;
                int views = int.Parse(parts[4].Trim());
                int likes = int.Parse(parts[5].Trim());

                movies[i] = new Movie(id, title, year, genre, views, likes);
            }

            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }
}
