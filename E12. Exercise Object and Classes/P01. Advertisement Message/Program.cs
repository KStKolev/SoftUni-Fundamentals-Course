namespace AdvertisementMessage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            GenerateFakeMessage(inputNumber);
        }

        private static void GenerateFakeMessage(int inputNumber)
        {
            Random random = new Random();
            string[] phrases = new string[] { "Excellent product.",
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can't live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            for (int i = 0; i < inputNumber; i++)
            {
                string phraseAdvertisment = phrases[random.Next(1, phrases.Length)];
                string eventAdvertisment = events[random.Next(1, events.Length)];
                string authorAdvertisment = authors[random.Next(1, authors.Length)];
                string citiesAdvertisment = cities[random.Next(1, cities.Length)];
                FakeAdvertismentMsg fakeMessage = new FakeAdvertismentMsg(phraseAdvertisment,
                    eventAdvertisment,
                    authorAdvertisment,
                    citiesAdvertisment);
                Console.WriteLine(fakeMessage);
            }
            Console.Read();
        }
    }

    public class FakeAdvertismentMsg
    {
        public FakeAdvertismentMsg(string phrase, string events, string authors, string cities)
        {
            this.Phrase = phrase;
            this.Events = events;
            this.Authors = authors;
            this.Cities = cities;
        }

        public string Phrase { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }

        public override string ToString()
        {
            return $"{Phrase} {Events} {Authors} - {Cities}";
        }
    }
}
