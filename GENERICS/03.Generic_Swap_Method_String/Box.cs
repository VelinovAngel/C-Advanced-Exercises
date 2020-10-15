using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Generic_Swap_Method_String
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();


        public Box(List<T> value)
        {
            this.Values = value;
        }


        // Swap(int firstIndex , int secondIndex)
        //{

        //}

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
