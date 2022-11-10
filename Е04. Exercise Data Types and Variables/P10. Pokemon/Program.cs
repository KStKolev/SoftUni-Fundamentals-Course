namespace Pokemon
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            int distanceBetweenOpponent = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            decimal halfpokePowerChecker = pokePower;
            int pokedOppponetsCount = 0;
            while (pokePower >= distanceBetweenOpponent)
            {
                pokePower -= distanceBetweenOpponent;
                pokedOppponetsCount++;
                if (pokePower == halfpokePowerChecker / 2)
                {
                    if (pokePower >= exhaustionFactor)
                    {
                        pokePower /= exhaustionFactor;
                    }
                    else if (pokePower < exhaustionFactor)
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedOppponetsCount);
        }
    }
}
