using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomMovie();
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Up", "Iron man", "Lost", "It", "Spider-man" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");
        }
    }
}
