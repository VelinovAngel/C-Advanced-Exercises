namespace WeWriteSoftware
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        private const string TextFileLocation = "../../../text.txt";
        private const string OutputFileLocation = "../../../output.txt";

        public static void Main()
        {
            // Invoke every method for the corresponding task in order to see the result file(s).
            // Please read the comments for the last task.
        }

        private static void EvenLines()
        {
            StringBuilder builder = new StringBuilder();

            using (StreamReader reader = new StreamReader(TextFileLocation))
            {
                int lineCounter = 0;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (lineCounter % 2 == 0)
                    {
                        Regex regex = new Regex("[-,.!?]");
                        line = regex.Replace(line, "@");
                        line = string.Join(" ", line.Split().Reverse());
                        builder.AppendLine(line);
                    }

                    lineCounter++;
                }
            }

            File.WriteAllText(OutputFileLocation, builder.ToString().TrimEnd());
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines(TextFileLocation);
            StringBuilder builder = new StringBuilder();
            string defaultLineFormat = "Line: {0}: {1} ({2})({3})";

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                int charCount = 0;
                int punctuationCount = 0;

                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (char.IsLetter(currentLine[j]))
                    {
                        charCount++;
                    }
                    else if (char.IsPunctuation(currentLine[j]))
                    {
                        punctuationCount++;
                    }
                }

                string result = string.Format(defaultLineFormat, i + 1, currentLine, charCount, punctuationCount);
                builder.AppendLine(result);
            }

            File.WriteAllText(OutputFileLocation, builder.ToString().TrimEnd());
        }

        private static void WordCount()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] words = File.ReadAllLines("../../../words.txt");
            string[] sentences = File.ReadAllLines(TextFileLocation);

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] currentSentenceWords = sentences[i].ToLower().Split();
                Regex regex = new Regex(@"\w+");

                foreach (var word in currentSentenceWords)
                {
                    // We need only the word itself, not the surrounding marks next to it (if there is such).
                    // Thus, a regex pattern is required.
                    string matchedWord = regex.Match(word).Value;

                    if (words.Any(x => x == matchedWord))
                    {
                        if (!wordCount.ContainsKey(matchedWord))
                        {
                            wordCount[matchedWord] = 0;
                        }

                        wordCount[matchedWord]++;
                    }
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (var item in wordCount.OrderByDescending(x => x.Key))
            {
                result.AppendLine($"{item.Key} - {item.Value}");
            }

            File.WriteAllText("../../../actualResult.txt", result.ToString().TrimEnd());

            result.Clear();

            foreach (var item in wordCount.OrderByDescending(x => x.Value))
            {
                result.AppendLine($"{item.Key} - {item.Value}");
            }

            File.WriteAllText("../../../expectedResult.txt", result.ToString().TrimEnd());
        }

        private static void CopyBinaryFile()
        {
            using (FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (FileStream writer = new FileStream("../../../copiedMe.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);

                        if (bytesRead == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        private static void DirectoryTraversal()
        {
            Dictionary<string, Dictionary<string, double>> extensionFileSize = new Dictionary<string, Dictionary<string, double>>();
            DirectoryInfo dir = new DirectoryInfo("../../../");
            FileInfo[] files = dir.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                string extension = files[i].Extension;
                string fileName = files[i].Name;
                double fileSize = files[i].Length;

                if (!extensionFileSize.ContainsKey(extension))
                {
                    extensionFileSize[extension] = new Dictionary<string, double>();
                }

                if (!extensionFileSize[extension].ContainsKey(fileName))
                {
                    extensionFileSize[extension][fileName] = fileSize;
                }
            }

            string desktopPathFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");

            using (StreamWriter writer = new StreamWriter(desktopPathFile))
            {
                foreach (var extension in extensionFileSize.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
                {
                    writer.WriteLine(extension.Key);

                    foreach (var file in extension.Value.OrderBy(f => f.Value))
                    {
                        writer.WriteLine($"--{file.Key} - {file.Value / 1024}kB");
                    }
                }
            }
        }

        private static void ZipAndExtract()
        {
            // First and foremost, it creates a zip file inside the project directory (the zip file contains the whole assembly directory).
            // Then, it unzips the zip file and extracts it on the desktop.
            // P.S. Apologies in case your desktop is overwhelmed, I just followed the task requirements.
            string directoryPath = Directory.GetCurrentDirectory();
            string zipPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../zipped.zip"));
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ZipFile.CreateFromDirectory(directoryPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, desktop);
        }
    }
}