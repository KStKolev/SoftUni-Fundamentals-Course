namespace MultiplyBigInteger
{
    using System;
    using System.Text;
    public class Program
    {
       public static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());
            MultiplyBigInteger(bigNumber, smallNumber);
        }

        private static void MultiplyBigInteger(string bigNumber, int smallNumber)
        {
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            if (smallNumber == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(bigNumber[i].ToString());
                int product = currDigit * smallNumber + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }
            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
            Console.Read();
        }
    }
}
