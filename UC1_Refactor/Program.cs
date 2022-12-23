using System;
using UC1_Refactor;

namespace MoodAnalyserMSTest
{
    class Program
    {
        public static void Main(string[] args)
        {          
            Console.WriteLine("Enter your mood: ");
           // string mood = Console.ReadLine();
            MoodAnalyser obj = new MoodAnalyser("I am in sad mood");
            Console.WriteLine(obj.analyseMood());
        }
    }
}
