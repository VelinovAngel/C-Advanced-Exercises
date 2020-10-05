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
                string[] tokens = input.Split(";");
                string commandName = tokens[0];
                string filterType = tokens[1];
                string argument = tokens[2];


                if (commandName == "Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName == "Remove filter")
                {
                    filters.Remove($"{filterType};{argument}");
                }
            }

            foreach (var filterLine in filters)
            {
                string[] tokens = filterLine.Split(';');
                string filterType = tokens[0];
                string arguments = tokens[1];

                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(arguments)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(arguments)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(arguments)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => p.Contains(arguments)).ToList();
                        break;
                }
            }

                Console.WriteLine(string.Join(" ",people));
        }
    }
}
