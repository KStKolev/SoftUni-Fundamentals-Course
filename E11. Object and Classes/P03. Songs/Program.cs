namespace Songs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < inputNumber; i++)
            {
                string inputText = Console.ReadLine();
                string[] textArray = inputText.Split("_");
                Song song = new Song(textArray[0], textArray[1], textArray[2]);
                songs.Add(song);
            }
            string command = Console.ReadLine();
            if (command.Equals("all"))
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Song currentSong = songs[i];
                    Console.WriteLine(currentSong.Name);
                }
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Song currentSong = songs[i];
                    if (command == currentSong.TypeList)
                    {
                        Console.WriteLine(currentSong.Name);
                    }
                }
            }
            Console.Read();
        }
        public class Song
        {
            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }

            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
