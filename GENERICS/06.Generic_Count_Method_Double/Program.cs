using System;
using System.Collections.Generic;

namespace _06.Generic_Count_Method_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> doubleColl = new List<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double currNum = double.Parse(Console.ReadLine());
                doubleColl.Add(currNum);
            }

            double compereNum = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>(doubleColl);

            Console.WriteLine(box.GetCountOfGreaterValues(compereNum));
        }
    }
}
