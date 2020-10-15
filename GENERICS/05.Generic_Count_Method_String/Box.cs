using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Generic_Count_Method_String
{
    public class Box<T> where T : IComparable
    {
        public List<T> Values { get; set; } = new List<T>();


        public Box(List<T> value)
        {
            this.Values = value;
        }


        // Swap(int firstIndex , int secondIndex)
        //{

        //}


        public int GetCountOfGreaterValues(T value)
        {
            int counter = 0;

            foreach (var currValue in Values)
            {
                if (value.CompareTo(currValue) < 0 )
                {
                    counter++;
                }
            }

            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T tempValue = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = tempValue;

        }
    }

}
