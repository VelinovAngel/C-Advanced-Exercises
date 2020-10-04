using System;
using System.IO.Compression;

namespace _0._6.Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../Books", "../../../Archive/Books.zip");
            Console.WriteLine("Creating files completed");


            ZipFile.ExtractToDirectory("../../../Archive/Books.zip", "../../../DemoResult");
            Console.WriteLine("Extracting files completed");
        }
    }
}
