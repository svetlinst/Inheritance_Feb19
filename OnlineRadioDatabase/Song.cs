namespace OnlineRadioDatabase
{
    using System;
    using System.Linq;

    public class Song
    {
        private string artistName;
        private string name;
        private string length;
        private long minutes;
        private long seconds;

        public string ArtistName
        {
            get => this.artistName;
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InavlidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length<3 || value.Length>30)
                {
                    throw new InvalidSongNameException();
                }
                this.name = value;
            }
        }

        public string Length
        {
            get => this.length;
            private set
            {
                try
                {
                    var tokens = value
                        .Split(':', StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray();
                }
                catch (Exception ex)
                {
                    throw new InvalidSongLengthException();
                }

                this.length = value;
            }
        }


        public long Minutes
        {
            get
            {
                return this.minutes;
            }
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.minutes = value;
            }
        }
        public long Seconds
        {
            get
            {
                return this.seconds;
            }
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.seconds = value;
            }
        }

        public Song(string artistName, string name, string length)
        {
            this.ArtistName = artistName;
            this.Name = name;
            this.Length = length;
            this.Minutes = length.Split(':', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray()[0];
            this.Seconds = length.Split(':', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray()[1];

        }
    }
}
