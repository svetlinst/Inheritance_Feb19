namespace OnlineRadioDatabase
{
    using System;

    public class InvalidSongMinutesException : InvalidSongException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}
