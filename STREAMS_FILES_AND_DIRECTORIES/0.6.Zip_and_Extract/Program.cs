using System;
using System.IO.Compression;

namespace _0._6.Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../Books", "../../../Books.zip");
            Console.WriteLine("Creating files completed");


            ZipFile.ExtractToDirectory("../../../Books.zip", "../../../");
            Console.WriteLine("Extracting files completed");
        }
    }
}
