namespace HomeWork10CSharpExListEx4
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
            while ((inputText = Console.ReadLine()) != "End")
            {
                List<string> listText = inputText
                    .Split()
                    .ToList();
                if (inputText.Contains("Add"))
                {
                    int number = int.Parse(listText[1]);
                    inputNumbers.Add(number);
                }
                else if (inputText.Contains("Insert"))
                {
                    int number = int.Parse(listText[1]);
                    int index = int.Parse(listText[2]);
                    if (index < 0 || index >= inputNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    inputNumbers.Insert(index, number);
                }
                else if (inputText.Contains("Remove"))
                {
                    int number = int.Parse(listText[1]);
                    if (number < 0 || number >= inputNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    inputNumbers.RemoveAt(number);
                }
                else if (inputText.Contains("left"))
                {
                    int index = int.Parse(listText[2]);
                    for (int i = 0; i < index; i++)
                    {
                        int firstIndex = inputNumbers[0];
                        inputNumbers.RemoveAt(0);
                        inputNumbers.Add(firstIndex);
                    }
                }
                else if (inputText.Contains("right"))
                {
                    int index = int.Parse(listText[2]);
                    for (int i = 0; i < index; i++)
                    {
                        int lastIndex = inputNumbers[inputNumbers.Count - 1];
                        inputNumbers.RemoveAt(inputNumbers.Count - 1);
                        inputNumbers.Insert(0, lastIndex);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
            Console.Read();
        }
    }
}
