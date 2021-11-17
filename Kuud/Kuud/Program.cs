using System;
using System.IO;

namespace Kuud
{
    class Program
    {
        static void Main(string[] args)
        {
            string autummFile = @"C:\Users\opilane\samples\autumm.txt";
            string winterFile = @"C:\Users\opilane\samples\winter.txt";

            string[] winterData = File.ReadAllLines(autummFile);
            string[] autummData = File.ReadAllLines(winterFile);

            File.ReadAllLines(autummFile, autummData);
            File.ReadAllLines(winterFile, winterData);



        }
    }
}
