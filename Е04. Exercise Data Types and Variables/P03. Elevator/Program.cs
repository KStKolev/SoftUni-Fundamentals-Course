namespace Elevator
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int peopleUsingElevator = int.Parse(Console.ReadLine());
            int capacityOfTheElevator = int.Parse(Console.ReadLine());
            int elevatorcount = 0;
            while (peopleUsingElevator > 0)
            {
                peopleUsingElevator -= capacityOfTheElevator;
                elevatorcount++;
            }
            Console.WriteLine(elevatorcount);
        }
    }
}
