namespace Race
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            PrintBestRacers(participants);
        }

        private static void PrintBestRacers(List<string> participants)
        {
            Dictionary<string, int> racerDistance = new Dictionary<string, int>();
            string inputText = string.Empty;
            string letterPattern = @"[A-Za-z]";
            string digitPattern = @"[0-9]";
            Regex letterRegex = new Regex(letterPattern);
            Regex digitRegex = new Regex(digitPattern);
            while ((inputText = Console.ReadLine()) != "end of race")
            {
                MatchCollection letterMatch = letterRegex.Matches(inputText);
                MatchCollection digitMatch = digitRegex.Matches(inputText);
                char[] name = letterMatch
                    .Select(x => x.Value)
                    .Select(letter => char.Parse(letter))
                    .ToArray();
                string participant = string.Join("", name);
                int distance = digitMatch.Select(x => int.Parse(x.Value)).Sum();
                if (participants.Contains(participant))
                {
                    if (!racerDistance.ContainsKey(participant))
                    {
                        racerDistance.Add(participant, distance);
                    }
                    else if (racerDistance.ContainsKey(participant))
                    {
                        racerDistance[participant] += distance;
                    }
                }
            }
            Dictionary<string, int> bestRacers = new Dictionary<string, int>(racerDistance.OrderByDescending(x => x.Value));
            int counter = 1;
            foreach (var currentRacer in bestRacers)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {currentRacer.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {currentRacer.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {currentRacer.Key}");
                }
                counter++;
            }
            Console.Read();
        }
    }
}
