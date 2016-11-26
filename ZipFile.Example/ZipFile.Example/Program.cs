using System;

namespace ZipFile.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string testFilePath = @"D:\TestFiles";
            string zipFilePath = @"D:\TestZipFiles\files.zip";
            string extractPath = @"D:\Files\extract";

            System.IO.Compression.ZipFile.CreateFromDirectory(testFilePath, zipFilePath);

            System.IO.Compression.ZipFile.ExtractToDirectory(zipFilePath, extractPath);

            Console.ReadKey();
        }
    }
}
