namespace ChangeList
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
            string inputText = string.Empty;
            int number = 0;
            while ((inputText = Console.ReadLine()) != "end")
            {
                List<string> listText = inputText
                    .Split()
                    .ToList();
                number = int.Parse(listText[1]);
                if (listText.Contains("Delete"))
                {
                    for (int i = 0; i < inputNumbers.Count; i++)
                    {
                        if (number == inputNumbers[i])
                        {
                            inputNumbers.Remove(number);
                        }
                    }
                }
                else if (listText.Contains("Insert"))
                {
                    int position = int.Parse(listText[2]);
                    inputNumbers.Insert(position, number);
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
