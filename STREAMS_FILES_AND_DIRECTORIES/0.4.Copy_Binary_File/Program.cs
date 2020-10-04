using System;
using System.IO;

namespace _0._4.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {

            using (FileStream stream = File.OpenRead("../../../input.jpg"))
            using (FileStream writeStream = File.OpenWrite("../../../output.jpg"))
            {
                BinaryReader reader = new BinaryReader(stream);
                BinaryWriter writer = new BinaryWriter(writeStream);

                byte[] buffer = new Byte[1024];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, 1024)) > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
