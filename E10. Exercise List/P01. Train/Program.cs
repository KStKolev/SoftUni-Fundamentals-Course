namespace Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int inputNumber = int.Parse(Console.ReadLine());
            string inputText = string.Empty;
            while ((inputText = Console.ReadLine()) != "end")
            {
                int numbers = 0;
                List<string> listText = inputText
                    .Split()
                    .ToList();
                if (inputText.Contains("Add"))
                {
                    inputNumbers.Add(int.Parse(listText[1]));
                    continue;
                }
                numbers += int.Parse(inputText);
                for (int i = 0; i < inputNumbers.Count; i++)
                {
                    if (numbers + inputNumbers[i] <= inputNumber)
                    {
                        inputNumbers[i] += numbers;
                        break;
                    }
                }
            }
            foreach (var item in inputNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.Read();
        }
    }
}
