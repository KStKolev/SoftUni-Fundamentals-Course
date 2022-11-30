namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> validUsernames = new List<string>();
            string[] inputUsername = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            PrintValidUsernames(validUsernames, inputUsername);
        }

        private static void PrintValidUsernames(List<string> validUsernames, string[] inputUsername)
        {
            for (int i = 0; i < inputUsername.Length; i++)
            {
                string user = inputUsername[i];
                if (user.Length >= 3 && user.Length <= 16)
                {
                    bool isValidUsername = true;
                    foreach (char currentUser in user)
                    {
                        if (char.IsLetterOrDigit(currentUser) || currentUser.Equals('-') || currentUser.Equals('_'))
                        {
                            continue;
                        }
                        else
                        {
                            isValidUsername = false;
                            break;
                        }
                    }
                    if (isValidUsername == true)
                    {
                        validUsernames.Add(user);
                    }
                }
            }
            Console.WriteLine(string.Join("\n", validUsernames));
            Console.Read();
        }
    }
}
