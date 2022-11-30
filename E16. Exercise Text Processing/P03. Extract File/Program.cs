namespace ExtractFile
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputFilePath = Console.ReadLine().Split(@"\");
            PrintSubtractedFileAndExtension(inputFilePath);
        }

        private static void PrintSubtractedFileAndExtension(string[] inputFilePath)
        {
            string[] inputSubtracted = inputFilePath[inputFilePath.Length - 1].Split(".");
            string fileName = inputSubtracted[0];
            string fileExtension = inputSubtracted[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
            Console.Read();
        }
    }
}
