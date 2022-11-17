namespace ListOfProducts
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<string> inputText = new List<string>();
            for (int i = 0; i < inputNumber; i++)
            {
                inputText.Add(Console.ReadLine());
            }
            inputText.Sort();
            for (int i = 1; i <= inputNumber; i++)
            {
                Console.WriteLine($"{i}.{inputText[i-1]}");
            }
            Console.Read();
        }
    }
}
