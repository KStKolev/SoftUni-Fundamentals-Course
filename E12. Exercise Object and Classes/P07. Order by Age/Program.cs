namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = string.Empty;
            inputText = PrintPersonalInformation();
        }

        private static string PrintPersonalInformation()
        {
            string inputText;
            List<PersonalInformation> personalInformations = new List<PersonalInformation>();
            while ((inputText = Console.ReadLine()) != "End")
            {
                string[] inputInformation = inputText.Split();
                string name = inputInformation[0];
                string id = inputInformation[1];
                int age = int.Parse(inputInformation[2]);
                PersonalInformation personalInformation = new PersonalInformation(name, id, age);
                if (personalInformations.Any(x => x.Id == personalInformation.Id))
                {
                    PersonalInformation newInformation = personalInformations.First(x => x.Id == personalInformation.Id);
                    personalInformations.Remove(newInformation);
                }
                personalInformations.Add(personalInformation);
            }
            foreach (var item in personalInformations.OrderBy(x => x.Age))
            {
                Console.WriteLine(item);
            }
            Console.Read();
            return inputText;
        }
    }
    public class PersonalInformation
    {
        public PersonalInformation(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
