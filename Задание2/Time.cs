using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Time
    {
        byte _hours;
        byte _minutes;

        public Time(byte _hours, byte _minutes)
        {
            this._hours = _hours;
            this._minutes = _minutes;
        }

        public byte Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public byte Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }

        public Time Subtract(Time other)
        {
            int CurrMinutes = this._hours * 60 + this._minutes;
            int OtherMinutes = other._hours * 60 + other._minutes;
            
            int diff = CurrMinutes - OtherMinutes;
            if (diff < 0)
            {
                diff += 1440;
            }

            byte resHours = Convert.ToByte(diff / 60);
            byte resMinutes = Convert.ToByte(diff % 60);

            return new Time(resHours, resMinutes);
        }

        public override string ToString() 
        {
            return $"Subtraction equals: {_hours}h {_minutes}m";
        }

        public static Time operator ++(Time time)
        {
            int totalMin = time._hours * 60 + time._minutes +1;
            totalMin %= 1440;
            byte resHours = Convert.ToByte(totalMin / 60);
            byte resMinutes = Convert.ToByte(totalMin % 60);
            return new Time(resHours, resMinutes);
        }
        public static Time operator --(Time time)
        {
            int totalMin = time._hours * 60 + time._minutes - 1;
            if (totalMin < 0) 
            { 
                totalMin += 1440;
            }
            byte resHours = Convert.ToByte(totalMin / 60);
            byte resMinutes = Convert.ToByte(totalMin % 60);
            return new Time(resHours, resMinutes);
        }

        public static explicit operator int(Time time)
        {
            return time._hours * 60 + time._minutes;
        }

        public static explicit operator bool(Time time)
        {
            return time._hours != 0 || time._minutes !=0;
        }

        public static bool operator <(Time time, Time other)
        {
            return (int)time < (int)other;
        }
        public static bool operator >(Time time, Time other)
        {
            return (int)time > (int)other;
        }
    }
}
