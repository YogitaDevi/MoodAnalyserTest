﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC1._2_MoodAnalyse
{
    public class MoodAnalyserClass
    {
        string input;
        public MoodAnalyserClass(string input)
        {
            this.input = input;
        }
        public string Analyse()
        {
            if (this.input.Contains("Sad"))
                return "Sad";
            else
                return "Happy";
        }
    }
}
