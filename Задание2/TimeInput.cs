using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class TimeInput
    {
        static public Time InputValidTime(string s)
        {
            bool isValid;
            byte hours, minutes;
            do
            {
                Console.WriteLine($"{ s } hours");
                string input = Console.ReadLine();
                isValid = byte.TryParse(input, out hours) & hours >=0 & hours <24;
                if (!isValid)
                {
                    Console.WriteLine($"Invalid input. Enter correct value of hours.");
                }
            } while (!isValid);
            do
            {
                Console.WriteLine($"{ s } minutes");
                string input = Console.ReadLine();
                isValid = byte.TryParse(input, out minutes) & minutes >= 0 & minutes < 60;
                if (!isValid)
                {
                    Console.WriteLine($"Invalid input. Enter correct value of minutes.");
                }
            } while (!isValid);

            return new Time(hours, minutes);
        }
    }
}