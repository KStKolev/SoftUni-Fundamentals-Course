﻿using System;

namespace DivisibleBy3
{
   public class Program
    {
       public static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
