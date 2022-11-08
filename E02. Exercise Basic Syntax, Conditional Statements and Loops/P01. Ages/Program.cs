using System;

namespace Ages
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int determinativeAge = int.Parse(Console.ReadLine());
            if (determinativeAge >= 0 && determinativeAge <= 2 )
            {
                Console.WriteLine("baby");
            }
            else if (determinativeAge >= 3 && determinativeAge <= 13)
            {
                Console.WriteLine("child");
            }
            else if (determinativeAge >= 14 && determinativeAge <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (determinativeAge >= 20 && determinativeAge <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (determinativeAge >= 66)
            {
                Console.WriteLine("elder");
            }
            Console.Read();
        }
    }
}
