namespace CommonElements
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstInputArray = Console.ReadLine().Split().ToArray();
            string[] secondInputArray = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < secondInputArray.Length; i++)
            {
                for (int l = 0; l < firstInputArray.Length; l++)
                {
                    if (firstInputArray[l] == secondInputArray[i])
                    {
                        Console.Write($"{firstInputArray[l]} ");
                    }
                }
            }
        }
    }
}
