using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class InputValid
    {
        static public int InputValidInt(string s) 
        {
        bool isValid;
        int a;
            do
            {
                Console.WriteLine(s);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out a);
                if (!isValid)
                {
                    Console.WriteLine($"Invalid input. Enter integer number.");
                }
            } while (!isValid);
            return a;
        }
    }
}
