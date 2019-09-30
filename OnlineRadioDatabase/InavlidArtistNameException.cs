namespace OnlineRadioDatabase
{
    using System;

    public class InavlidArtistNameException : InvalidSongException
    {
        public override string Message
        {
            get => "Artist name should be between 3 and 20 symbols.";
        }
    }
}
