using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _0._1.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ "-", ",", ".", "!", "?"}

            //char[] pattern = new char[] { '-', ',', '.', '!', '?' };
            int counter = 0;

            Regex regex = new Regex(@"[-,.!?]");
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            //string newLine = RepleaceString(line, pattern);
                            string newLine = regex.Replace(line, "@");
                            var reverseLine = newLine.Split().ToArray().Reverse();
                            writer.WriteLine(string.Join(' ', reverseLine));

                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }

}


