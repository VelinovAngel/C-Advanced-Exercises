using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < numOfStudents; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!grades.ContainsKey(student))
                {
                    grades.Add(student, new List<decimal>() { grade });
                }
                else
                {
                    grades[student].Add(grade);
                }
            }

            foreach (var kvp in grades)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    allGrades.Append($"{kvp.Value[i]:f2} ");
                }
                Console.WriteLine($"{kvp.Key} -> {allGrades}(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
