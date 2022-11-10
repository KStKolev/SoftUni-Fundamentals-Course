namespace ConcatNames
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{secondName}");
            Console.Read();
        }
    }
}
