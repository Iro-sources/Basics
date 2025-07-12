using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class2
    {

        //The Switch Statement
        public void SwitchSample(int x)
        {//Note Case values must be constant expressions, variables are not permitted.
         //It must be declared with the const keyword
            switch (x)
            {
                case 1:
                    Console.WriteLine("integerA = 1");
                    break;
                case 2:
                    Console.WriteLine("integerA = 2");
                    break;
                case 3:
                    Console.WriteLine("integerA = 3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1, 2, or 3");
                    break;
            }
        }

        //If the implementation is completely the same with multiple cases, you can specify multiple cases before
        //specifying an implementation:

        public void SwitchSample2(string country)

        {
            string language;
            switch (country)
            {
                case "au":
                case "uk":
                case "us":
                    language = "English";
                    break;
                case "at":
                case "de":
                    language = "Germany";
                    break;

            }
        }
    }
}
