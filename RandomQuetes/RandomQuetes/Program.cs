using System;

namespace RandomQuetes
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\users\opilane\samples\quotes.txt"
            string[] DataFromFile = File.ReadAllLines(filePath);

            Console.WriteLine(DataFromFile[0]);

            Random rnd = new Random();
            int randomIndex = rnd.Next(1, DataFromFile.Length);
            Console.WriteLine(DataFromFile[randomIndex]);
                                                   

        }
    }
}
