namespace StarEnigma
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            StarEnigma(timesToLoop);
        }

        private static void StarEnigma(int timesToLoop)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string decryptedPattern = @"^[^\@\-\!\:\>]*?\@(?<name>[A-Z][a-z]+)[^\@\-\!\:\>]*?\:(?<population>[0-9]+)[^\@\-\!\:\>]*?\!(?<attack>A|D)[^\@\-\!\:\>]*?\![^\@\-\!\:\>]*?\-\>(?<count>[0-9]+)[^\@\-\!\:\>]*?$";
            Regex regex = new Regex(decryptedPattern);
            string inputText = string.Empty;
            for (int i = 1; i <= timesToLoop; i++)
            {
                inputText = Console.ReadLine();
                char[] decryptedSymbols = DecryptSymbols(inputText);
                string decryptedMessage = new string(decryptedSymbols);
                Match match = regex.Match(decryptedMessage);
                AddPlanets(attackedPlanets, destroyedPlanets, match);
            }
            PrintPlanets(attackedPlanets, destroyedPlanets);
        }

        private static char[] DecryptSymbols(string inputText)
        {
            char[] symbolsFromInput = inputText.ToLower().ToCharArray();
            int count = 0;
            foreach (char currentSymbol in symbolsFromInput)
            {
                if (currentSymbol.Equals('s') || currentSymbol.Equals('t')
                    || currentSymbol.Equals('a') || currentSymbol.Equals('r'))
                {
                    count++;
                }
            }
            char[] decryptedSymbols = inputText.ToCharArray();
            for (int k = 0; k < decryptedSymbols.Length; k++)
            {
                decryptedSymbols[k] = (char)(decryptedSymbols[k] - count);
            }

            return decryptedSymbols;
        }

        private static void AddPlanets(List<string> attackedPlanets, List<string> destroyedPlanets, Match match)
        {
            if (match.Success)
            {
                string planetName = match.Groups["name"].Value;
                char typeOfAttack = char.Parse(match.Groups["attack"].Value);
                if (typeOfAttack.Equals('A'))
                {
                    attackedPlanets.Add(planetName);
                }
                else if (typeOfAttack.Equals('D'))
                {
                    destroyedPlanets.Add(planetName);
                }
            }
        }

        private static void PrintPlanets(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var currentAttack in attackedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {currentAttack}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var currentDestoyed in destroyedPlanets.OrderBy(name => name))
            {
                Console.WriteLine($"-> {currentDestoyed}");
            }
            Console.Read();
        }
    }
}
