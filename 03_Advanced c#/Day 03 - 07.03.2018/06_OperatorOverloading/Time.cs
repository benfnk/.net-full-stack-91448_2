using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Time
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="p_Hours"></param>
        /// <param name="p_Minutes"></param>
        /// 
        public Time(int p_Hours, int p_Minutes)
        {
            Hours = p_Hours;
            Minutes = p_Minutes;
        }

        public static Time operator +(Time first, Time second)
        {            
            return new Time(first.Hours + second.Hours + ((int)((first.Minutes + second.Minutes) / 60)) , (first.Minutes + second.Minutes) % 60);
        }

        public static Time operator -(Time first, Time second)
        {
            return new Time(first.Hours - second.Hours - ((int)((first.Minutes + second.Minutes) / 60)), (first.Minutes - second.Minutes) % 60);
        }

        public int this[int index]
        {
            get
            {
                if(index == 0)
                {
                    return this.Hours;
                }
                else
                {
                    return this.Minutes;
                }
            }
            set
            {
                if (index == 0)
                {
                    this.Hours = value;
                }
                else
                {
                    this.Minutes = value;
                }
            }

        }

        // Change string to Time
        public static implicit operator Time(string str)
        {
             var values=  str.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Time a = new Time(int.Parse(values[0]), int.Parse(values[1]));
            return a;

        }

        public static implicit operator string(Time objTime)
        {
            return objTime.Hours + ":" + objTime.Minutes;

        }

        public static Time operator ++(Time first)
        {
            first.Minutes++;
            return first;
        }

    


        public static bool operator ==(Time first, Time second)
        {
            if (object.ReferenceEquals(first, null) && object.ReferenceEquals(second, null))
            {
                return true;
            }
            else if (object.ReferenceEquals(first, null) || object.ReferenceEquals(second, null))
                return false;
            return first.Equals(second);
        }

        public static bool operator !=(Time first, Time second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object obj)
        {
            if(obj is Time)
            {
                return (obj as Time).Hours == this.Hours && (obj as Time).Minutes == this.Minutes;
            }

            return false;
        }

    }
}
