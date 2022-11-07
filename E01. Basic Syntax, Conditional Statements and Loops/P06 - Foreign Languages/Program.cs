using System;

namespace ForeignLanguages
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string contryLanguage = Console.ReadLine();
            switch (contryLanguage)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            Console.Read();
        }
    }
}
