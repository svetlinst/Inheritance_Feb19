namespace OnlineRadioDatabase
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var songsToAded = long.Parse(Console.ReadLine());
            long totalMinutes = 0;
            long totalSeconds = 0;
            long songCounter = 0;
            for (long i = 0; i < songsToAded; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3)
                {
                    throw new InvalidSongException();
                }
                try
                {
                    Song song = new Song(tokens[0], tokens[1], tokens[2]);
                    Console.WriteLine("Song added.");
                    totalMinutes += song.Minutes;
                    totalSeconds += song.Seconds;
                    songCounter++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");

                }
            }
            totalSeconds += totalMinutes * 60; 
            Console.WriteLine($"Songs added: {songCounter}");

            Console.WriteLine($"Playlist length: {totalSeconds/3600}h {(totalSeconds % 3600)/60}m {(totalSeconds % 3600) % 60}s");
        }
    }
}
