namespace RepeatString
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            RepeatString();
            Console.ReadLine();
        }
        private static void RepeatString()
        {
            string inputString = Console.ReadLine();
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                Console.Write(inputString);
            }
        }
    }
}
