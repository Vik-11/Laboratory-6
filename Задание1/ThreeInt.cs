using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class ThreeOfInt
    {
        protected int _x;
        protected int _y;
        protected int _z;

        public ThreeOfInt()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }
        public ThreeOfInt(int _x, int _y, int _z)
        {
            this._x = _x;
            this._y = _y;
            this._z = _z;
        }
        public ThreeOfInt(ThreeOfInt previousTriplet)
        {
            _x = previousTriplet._x;
            _y = previousTriplet._y;
            _z = previousTriplet._z;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }
        public int Multiply()
        {
            return _x * _y * _z;
        }

        public override string ToString()
        {
            return ($"Multiplication of {_x}, {_y}, {_z} equals to {Multiply()}");
        }
    }

    internal class RectParallelepiped : ThreeOfInt 
        {
        public RectParallelepiped(int _x, int _y, int _z) : base(_x, _y, _z) { }

        public int LateralSurfaceArea()
        {
            return 2 * (_x * _z + _y * _z);
        }
        public int TotalSurfaceArea()
        {
            return 2 * (_x * _z + _x * _y + _y * _z);
        }
        public string ShowLateral()
        {
            return ($"Lateral surface area of rectangular parallelepiped is { LateralSurfaceArea() }");
        }
        public string ShowTotal()
        {
            return ($"Total surface area of rectangular parallelepiped is {TotalSurfaceArea()}");
        }
        public string ShowVolume()
        {
            return ($"Volume of rectangular parallelepiped is { Multiply() } \n\n");
        }
        static public int InputValidValue(string s)
        {
            bool isValid;
            int a;
            do
            {
                Console.WriteLine(s);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out a) & a > 0;
                if (!isValid)
                {
                    Console.WriteLine($"Invalid value. Enter integer number.");
                }
            } while (!isValid);
            return a;
        }
    }
}
