namespace Login
{
   using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string attemptPassword = string.Empty;
            string password = string.Empty;
            int passwordCount = 1;
            for (int input = username.Length - 1; input >= 0; input--)
            {
                password += username[input];
            }
            while (attemptPassword != password)
            {
                attemptPassword = Console.ReadLine();
                if (passwordCount >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (attemptPassword != password)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                passwordCount++;
            }
            if (attemptPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
