namespace PrintPartOfTheASCIITable
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int charStart = int.Parse(Console.ReadLine());
            int charEnd = int.Parse(Console.ReadLine());
            for (int i = charStart; i <= charEnd; i++)
            {
                int asciiSymbols = i;
                Console.Write((char)asciiSymbols + " ");
            }
        }
    }
}
