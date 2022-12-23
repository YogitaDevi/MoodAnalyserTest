using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC1._1_Refactor
{
    public class MoodAnalyser
    {
        private string message;
        
        public MoodAnalyser(string message) //parameterized constructor
        {
            this.message = message;
        }
        public string analyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
                return "sad";
            else
                return "happy";
        }
    
    }
}
