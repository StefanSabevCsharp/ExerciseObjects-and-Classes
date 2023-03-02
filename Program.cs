using System;

namespace ExerciseObjects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Phrases[random.Next(Phrases.Length)]} {Events[random.Next(Events.Length)]}" +
                    $" {Authors[random.Next(Authors.Length)]} – {Cities[random.Next(Cities.Length)]}.");
            }

        }
    }
}
