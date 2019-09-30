namespace OnlineRadioDatabase
{
    using System;

    public class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Song length should be between 0 second and 14 minutes and 59 seconds.";
    }
}
