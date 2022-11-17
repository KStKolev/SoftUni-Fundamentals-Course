namespace MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstInputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> thirdInputNumbers = new List<int>();
            if (secondInputNumbers.Count >= firstInputNumbers.Count)
            {
                for (int i = 0; i < firstInputNumbers.Count; i++)
                {
                    thirdInputNumbers.Add(firstInputNumbers[i]);
                    thirdInputNumbers.Add(secondInputNumbers[i]);
                }
                for (int i = firstInputNumbers.Count; i < secondInputNumbers.Count; i++)
                {
                    thirdInputNumbers.Add(secondInputNumbers[i]);
                }
            }
            else if (firstInputNumbers.Count >= secondInputNumbers.Count)
            {
                for (int i = 0; i < secondInputNumbers.Count; i++)
                {
                    thirdInputNumbers.Add(firstInputNumbers[i]);
                    thirdInputNumbers.Add(secondInputNumbers[i]);
                }
                for (int i = secondInputNumbers.Count; i < firstInputNumbers.Count; i++)
                {
                    thirdInputNumbers.Add(firstInputNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", thirdInputNumbers));
            Console.Read();
        }
    }
}
