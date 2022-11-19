namespace HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<string> listText = new List<string>();
            for (int i = 0; i < inputNumber; i++)
            {
                string inputText = Console.ReadLine();
                List<string> text = inputText
                    .Split()
                    .ToList();
                if (inputText.Contains("not"))
                {
                    if (listText.Contains(text[0]))
                    {
                        listText.Remove(text[0]);
                        continue;
                    }
                    Console.WriteLine($"{text[0]} is not in the list!");
                    continue;
                }
                if (listText.Contains(text[0]))
                {
                    Console.WriteLine($"{text[0]} is already in the list!");
                    continue;
                }
                listText.Add(text[0]);
            }
            foreach (var item in listText)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
