using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UC2_HandleException
{
    public class MoodAnalyser
    {
        public string message;  //instance variable
        public MoodAnalyser(string message) //parameterized constructor 
        {
            this.message = message;
        }
        public string Analyser()  //Analyser method find mood
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new Exception("The string is empty, you must enter something");
                }
                else if (this.message.ToUpper().Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);
            }
            return "null";
        }
        
    }
}
