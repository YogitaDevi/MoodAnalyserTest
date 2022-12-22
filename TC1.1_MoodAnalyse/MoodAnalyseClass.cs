using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC1._1_MoodAnalyse
{
    public class MoodAnalyseClass
    {
        string input;
        public MoodAnalyseClass(string input)
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
