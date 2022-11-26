namespace RepeatStrings
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split();
            for (int i = 0; i < inputWords.Length; i++)
            {
                for (int k = 0; k < inputWords[i].Length; k++)
                {
                    Console.Write(inputWords[i]);
                }
            }
            Console.Read();
        }
    }
}
