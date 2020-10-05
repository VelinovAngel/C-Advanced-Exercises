using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            string input = string.Empty;
            List<string> filters = new List<string>();

            while ((input = Console.ReadLine()) != "Print")
            {
                if (input.StartsWith("Add filter;"))
                {
                    filters.Add(input);
                }
                else if (input.StartsWith("Remove filter;"))
                {
                    filters.Remove(input);
                }
            }

            foreach (var filterLine in filters)
            {
                string[] tokens = filterLine.Split(';');
                string commnadType = tokens[0];


            }

        }
    }
}
