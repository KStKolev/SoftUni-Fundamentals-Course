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
            Catalog catalog = new Catalog();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] vehicleTypeArray = command.Split("/");
                string typeOfVehicle = vehicleTypeArray[0];
                string brand = vehicleTypeArray[1];
                string model = vehicleTypeArray[2];
                if (typeOfVehicle.Equals("Truck"))
                {
                    int weight = int.Parse(vehicleTypeArray[3]);
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }
                else if (typeOfVehicle.Equals("Car"))
                {
                    int horsePower = int.Parse(vehicleTypeArray[3]);
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            Console.Read();
        }
        public class Catalog
        {
            public Catalog()
            {
                Trucks = new List<Truck>();
                Cars = new List<Car>();
            }

            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }

        }
        public class Truck
        {
            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Car
        {
            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
