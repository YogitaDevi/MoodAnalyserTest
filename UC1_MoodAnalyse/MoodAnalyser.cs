using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_MoodAnalyse
{
    public class MoodAnalyser
    {
        string input;
        public MoodAnalyser(string input)
        {
            this.input = input;
        }

        public string Analyse()
        {
            if (this.input.Contains("Sad"))
                return "Sad Mood";
            else
                return "Happy Mood";
        }
    }
}
