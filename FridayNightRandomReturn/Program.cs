using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomMovie;
            string[] movies = { "Up", "Iron man", "Lost", "It", "Spider-man" };

            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will watch {randomMovie}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
