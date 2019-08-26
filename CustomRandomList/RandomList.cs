﻿namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        Random random = new Random();
        public string RandomString()
        {
            return this[random.Next(0, this.Count)];
        }
    }
}
