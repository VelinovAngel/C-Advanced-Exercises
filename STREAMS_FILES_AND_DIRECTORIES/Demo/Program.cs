using System;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../../text.txt"))
            {
                writer.WriteLine();
            }
        }
    }
}
