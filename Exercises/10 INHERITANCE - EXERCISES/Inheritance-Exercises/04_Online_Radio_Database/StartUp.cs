using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var listOfSongs = new List<Song>();
        int numberOfSongs = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                string[] input = Console.ReadLine().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (input.Length<3)
                {
                    Console.WriteLine("Invalid song.");
                    continue;
                }
                string artistName = input[0];
                string songName = input[1];

                string[] minutesAndSeconds = input[2].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    int minutes = int.Parse(minutesAndSeconds[0]);
                    int seconds = int.Parse(minutesAndSeconds[1]);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid song length.");
                    continue;
                }

                Song song = new Song(artistName, songName, int.Parse(minutesAndSeconds[0]), int.Parse(minutesAndSeconds[1]));
                Console.WriteLine("Song added.");
                listOfSongs.Add(song);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine($"Songs added: {listOfSongs.Count}");
        long timeInSecond = 0;
        foreach (var song in listOfSongs)
        {
            timeInSecond += song.TotalDurationSeconds;
        }

        long hours = timeInSecond / 3600;
        timeInSecond -= hours*3600;
        long minutesEnd = timeInSecond / 60;
        timeInSecond -= minutesEnd * 60;

        Console.WriteLine($"Playlist length: {hours}h {minutesEnd}m {timeInSecond}s");
       
    }
}

