namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> printVehicles = new List<Vehicle>();
            int truckCount = 0;
            int carCount = 0;
            decimal carHorsePower = 0;
            decimal truckHorsePower = 0;
            command = AddVehicles(vehicles, ref truckCount, ref carCount, ref carHorsePower, ref truckHorsePower);
            command = PrintInputModelVehicle(vehicles, printVehicles);
            carHorsePower = SumCarAverageHorsePower(carCount, carHorsePower);
            truckHorsePower = SumTruckHorsePowerAverage(truckCount, truckHorsePower);
            Console.Read();
        }

        private static string AddVehicles(List<Vehicle> vehicles, ref int truckCount, ref int carCount, ref decimal carHorsePower, ref decimal truckHorsePower)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicleInformation = command.Split();
                string typeOfVehicle = vehicleInformation[0];
                string model = vehicleInformation[1];
                string color = vehicleInformation[2];
                decimal horsePower = decimal.Parse(vehicleInformation[3]);
                if (typeOfVehicle.Equals("car"))
                {
                    typeOfVehicle = "Car";
                    Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                    vehicles.Add(vehicle);
                    carHorsePower += horsePower;
                    carCount++;
                }
                else if (typeOfVehicle.Equals("truck"))
                {
                    typeOfVehicle = "Truck";
                    Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                    vehicles.Add(vehicle);
                    truckHorsePower += horsePower;
                    truckCount++;
                }
            }

            return command;
        }

        private static string PrintInputModelVehicle(List<Vehicle> vehicles, List<Vehicle> printVehicles)
        {
            string command;
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                if (vehicles.Any(x => x.Model.Equals(command)))
                {
                    Vehicle printVehicle = vehicles.Find(x => x.Model.Equals(command));
                    printVehicles.Add(printVehicle);
                }
            }
            foreach (var item in printVehicles)
            {
                Console.WriteLine($"Type: {item.TypeOfVehicle}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Color: {item.Color}");
                Console.WriteLine($"Horsepower: {item.HorsePower}");
            }

            return command;
        }

        private static decimal SumTruckHorsePowerAverage(int truckCount, decimal truckHorsePower)
        {
            if (truckCount > 0)
            {
                truckHorsePower /= truckCount;
            }
            Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower:F2}.");
            return truckHorsePower;
        }

        private static decimal SumCarAverageHorsePower(int carCount, decimal carHorsePower)
        {
            if (carCount > 0)
            {
                carHorsePower /= carCount;
            }
            Console.WriteLine($"Cars have average horsepower of: {carHorsePower:F2}.");
            return carHorsePower;
        }
    }
    public class Vehicle
    {
        public Vehicle(string typeOfVehicle, string model, string color, decimal horsePower)
        {
            this.TypeOfVehicle = typeOfVehicle;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal HorsePower { get; set; }
    }
}
