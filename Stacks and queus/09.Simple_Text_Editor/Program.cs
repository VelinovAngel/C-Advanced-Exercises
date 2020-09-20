using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            Stack<string> version = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandProps = Console.ReadLine().Split();

                string command = commandProps[0];

                switch (command)
                {
                    case "1":
                        version.Push(text.ToString());
                        string textToAdd = commandProps[1];
                        text.Append(textToAdd);
                        break;

                    case "2":
                        version.Push(text.ToString());
                        int removeElements = int.Parse(commandProps[1]);
                        text.Remove(text.Length - removeElements , removeElements);
                        break;

                    case "3":
                        int index = int.Parse(commandProps[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;

                    case "4":
                        text.Clear();
                        text.Append(version.Pop());
                        break;
                }
            }
        }
    }
}
