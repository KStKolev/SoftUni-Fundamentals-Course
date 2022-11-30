namespace StringExplosion
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            inputText = SymbolExplosion(inputText);
        }

        private static string SymbolExplosion(string inputText)
        {
            int bomb = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (bomb > 0 && inputText[i] != '>')
                {
                    inputText = inputText.Remove(i, 1);
                    i--;
                    bomb--;
                }
                else if (inputText[i].Equals('>'))
                {
                    bomb += int.Parse(inputText[i + 1].ToString());
                }
            }
            Console.WriteLine(inputText);
            Console.Read();
            return inputText;
        }
    }
}
