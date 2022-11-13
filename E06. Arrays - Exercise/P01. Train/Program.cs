namespace Train
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] passengersArray = new int[numberOfWagons];
            int sumOfPassengers = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                int numberOfPassengers = int.Parse(Console.ReadLine());
                passengersArray[i] += numberOfPassengers;
                sumOfPassengers += numberOfPassengers;
            }
            foreach (var item in passengersArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPassengers);
        }
    }
}
