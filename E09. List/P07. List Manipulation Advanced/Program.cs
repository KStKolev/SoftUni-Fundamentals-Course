namespace ListManipulationAdvanced
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
            int value = 0;
            bool isChanged = false;
            while ((inputText = Console.ReadLine()) != "end")
            {
                string[] textArray = inputText.Split().ToArray();
                if (inputText.Contains("Contains"))
                {
                    value = int.Parse(textArray[1]);
                    if (inputNumbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (inputText.Contains("Add"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.Add(value);
                    isChanged = true;
                }
                else if (inputText.Contains("At"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.RemoveAt(value);
                    isChanged = true;
                }
                else if (inputText.Contains("Remove"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.Remove(value);
                    isChanged = true;
                }
                else if (inputText.Contains("Insert"))
                {
                    value = int.Parse(textArray[1]);
                    int secondIndex = int.Parse(textArray[2]);
                    inputNumbers.Insert(secondIndex, value);
                    isChanged = true;
                }
                else if (inputText == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x % 2 == 0)));
                }
                else if (inputText == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x % 2 != 0)));
                }
                else if (inputText == "GetSum")
                {
                    Console.WriteLine(inputNumbers.Sum());
                }
                else if (inputText.Contains("Filter"))
                {
                    string condition = textArray[1];
                    value = int.Parse(textArray[2]);
                    if (condition.Equals(">"))
                    {
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x > value)));
                    }
                    else if (condition.Equals(">="))
                    {
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x >= value)));
                    }
                    else if (condition.Equals("<"))
                    {
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x < value)));
                    }
                    else if (condition.Equals("<="))
                    {
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(x => x <= value)));
                    }
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", inputNumbers));
            }
        }
    }
}
