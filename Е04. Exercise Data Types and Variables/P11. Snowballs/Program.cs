namespace Snowballs
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger biggestValue = BigInteger.MinusOne;
            int snowballSnowForBiggestBall = 0;
            int snowballTimeSnowForBiggestBall = 0;
            int snowballQualitySnowForBiggestBall = 0;
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > biggestValue)
                {
                    biggestValue = snowballValue;
                    snowballSnowForBiggestBall = snowballSnow;
                    snowballTimeSnowForBiggestBall = snowballTime;
                    snowballQualitySnowForBiggestBall = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowForBiggestBall} : {snowballTimeSnowForBiggestBall} = " +
                $"{biggestValue} ({snowballQualitySnowForBiggestBall})");
        }
    }
}
