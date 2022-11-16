namespace PasswordValidator
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            if (FirstValidationRule(inputPassword) == true && SecondValidationRule(inputPassword) == true
                && ThirdValidationRule(inputPassword) == true)
            {
                Console.WriteLine("Password is valid");
            }
            if (FirstValidationRule(inputPassword) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (SecondValidationRule(inputPassword) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (ThirdValidationRule(inputPassword) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            Console.Read();
        }
        private static bool FirstValidationRule(string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool SecondValidationRule(string inputPassword)
        {
            foreach (char inputChar in inputPassword)
            {
                if (!Char.IsLetterOrDigit(inputChar))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool ThirdValidationRule(string inputPassword)
        {
            int digitCount = 0;
            foreach (char inputChar in inputPassword)
            {
                if (Char.IsDigit(inputChar))
                {
                    digitCount++;
                }
            }
            if (digitCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
