namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InvalidSongException : ArgumentException
    {
        public override string Message => "Invalid song.";
    }
}
