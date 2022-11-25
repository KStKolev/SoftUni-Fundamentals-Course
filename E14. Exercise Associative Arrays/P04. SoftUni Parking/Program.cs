namespace SoftUniParking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int timestoLoop = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingRegistration = new Dictionary<string, string>();
            OnlineParkingRegistrations(timestoLoop, parkingRegistration);
        }

        private static void OnlineParkingRegistrations(int timestoLoop, Dictionary<string, string> parkingRegistration)
        {
            for (int i = 0; i < timestoLoop; i++)
            {
                string inputcommand = Console.ReadLine();
                string[] arrayCommand = inputcommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = arrayCommand[0];
                string username = arrayCommand[1];
                if (command.Equals("register"))
                {
                    string licenseNumber = arrayCommand[2];
                    if (!parkingRegistration.ContainsKey(username))
                    {
                        parkingRegistration.Add(username, licenseNumber);
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingRegistration[username]}");
                    }
                }
                else if (command.Equals("unregister"))
                {
                    if (!parkingRegistration.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parkingRegistration.Remove(username);
                    }
                }
            }
            foreach (var currentUsername in parkingRegistration)
            {
                Console.WriteLine($"{currentUsername.Key} => {currentUsername.Value}");
            }
            Console.Read();
        }
    }
}
