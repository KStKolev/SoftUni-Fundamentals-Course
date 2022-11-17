namespace ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string inputText = string.Empty;
            int value = 0;
            while ((inputText = Console.ReadLine()) != "end")
            {
               string[] textArray = inputText.Split().ToArray();
                if (inputText.Contains("Add"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.Add(value);
                }
                else if (inputText.Contains("At"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.RemoveAt(value);
                }
                else if (inputText.Contains("Remove"))
                {
                    value = int.Parse(textArray[1]);
                    inputNumbers.Remove(value);
                }
                else if (inputText.Contains("Insert"))
                {
                    value = int.Parse(textArray[1]);
                    int secondIndex = int.Parse(textArray[2]);
                    inputNumbers.Insert(secondIndex, value);
                }
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
            Console.Read();
        }
    }
}
