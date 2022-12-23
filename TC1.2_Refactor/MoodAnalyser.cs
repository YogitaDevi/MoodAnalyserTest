using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC1._2_Refactor
{
    public class MoodAnalyser
    {
        private string message;
        //public MoodAnalyser() //default constructor
        //{

        //}
        public MoodAnalyser(string message) //parameterized constructor
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (this.message.ToLower().Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    
    }
}
