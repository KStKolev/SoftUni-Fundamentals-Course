namespace LowerOrUpper
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string nextSymbol = symbol.ToString();
            if (nextSymbol == nextSymbol.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else if (nextSymbol == nextSymbol.ToLower())
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
