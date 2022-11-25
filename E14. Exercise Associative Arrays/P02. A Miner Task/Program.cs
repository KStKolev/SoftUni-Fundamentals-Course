namespace AMinerTask
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, long> resourceManagment = new Dictionary<string, long>();
            ResourceManagments(resourceManagment);
        }

        private static void ResourceManagments(Dictionary<string, long> resourceManagment)
        {
            string inputText = string.Empty;
            string resource = string.Empty;
            int count = 1;
            while ((inputText = Console.ReadLine()) != "stop")
            {
                if (count % 2 != 0)
                {
                    resource = inputText;
                    if (!resourceManagment.ContainsKey(inputText))
                    {
                        resourceManagment.Add(resource, 0);
                    }
                }
                else
                {
                    resourceManagment[resource] += int.Parse(inputText);
                }
                count++;
            }
            foreach (var currentResource in resourceManagment)
            {
                Console.WriteLine($"{currentResource.Key} -> {currentResource.Value}");
            }
            Console.Read();
        }
    }
}
