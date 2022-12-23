using System;
using TC1._2_Refactor;

namespace MoodAnalyserMSTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your mood: ");
            string mood = Console.ReadLine();
            MoodAnalyser obj = new MoodAnalyser(mood);
            Console.WriteLine(obj.analyseMood());
        }
    }
}

