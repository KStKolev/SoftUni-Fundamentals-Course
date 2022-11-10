namespace BeerKegs
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfBeerKegs = int.Parse(Console.ReadLine());
            BigInteger biggestBeerKegVolume = 0;
            string biggestBeerKegModel = string.Empty;
            while (numberOfBeerKegs > 0)
            {
                string beerKegModel = Console.ReadLine();
                double beerKegRadius = double.Parse(Console.ReadLine());
                long beerKegHeight = long.Parse(Console.ReadLine());
                BigInteger beerKegVolume = (BigInteger)Math.PI * (BigInteger)Math.Pow(beerKegRadius, 2) * beerKegHeight;
                if (biggestBeerKegVolume < beerKegVolume)
                {
                    biggestBeerKegVolume = beerKegVolume;
                    biggestBeerKegModel = beerKegModel;
                }
                numberOfBeerKegs--;
            }
            Console.WriteLine(biggestBeerKegModel);
        }
    }
}
