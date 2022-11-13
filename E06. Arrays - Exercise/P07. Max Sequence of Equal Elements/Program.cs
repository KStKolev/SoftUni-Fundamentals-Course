namespace MaxSequenceOfEqualElements
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintTheLargestSequence();
        }

        private static void PrintTheLargestSequence()
        {
            string[] inputArray = Console.ReadLine().Split();
            int countForSingle = 1;
            int countTheMost = 1;
            string firstDigit = inputArray[0];
            string printTheDigits = string.Empty;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (firstDigit.Equals(inputArray[i]))
                {
                    countForSingle++;
                }
                else if (firstDigit != inputArray[i])
                {
                    CompareTheCount(countForSingle, ref countTheMost, firstDigit, ref printTheDigits);
                    firstDigit = inputArray[i];
                    countForSingle = 1;
                }
            }
            CompareTheCount(countForSingle, ref countTheMost, firstDigit, ref printTheDigits);
            for (int i = 0; i < countTheMost; i++)
            {
                Console.Write($"{printTheDigits} ");
            }
            Console.Read();
        }

        private static void CompareTheCount(int countForSingle, ref int countTheMost, string firstDigit, ref string printTheDigits)
        {
            if (countForSingle > countTheMost)
            {
                countTheMost = countForSingle;
                printTheDigits = firstDigit;
            }
        }
    }
}
