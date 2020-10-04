using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _0._5.Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryFile = new DirectoryInfo("../../../");
            FileInfo[] files = directoryFile.GetFiles();

            foreach (var file in files)
            {
                if (!fileInfo.ContainsKey(file.Extension))
                {
                    fileInfo.Add(file.Extension, new Dictionary<string, double>());
                }

                fileInfo[file.Extension].Add(file.Name, file.Length / 1000.00);
            }

            

            using (StreamWriter writer =
                new StreamWriter
                (@$"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}DirectoryTraversal.txt"))
            {

                foreach (var kvp in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
                {
                    writer.WriteLine($"{kvp.Key}");
                    foreach (var item in kvp.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{item.Key} - {item.Value}kb");
                    }
                }
            }

        }
    }
}
