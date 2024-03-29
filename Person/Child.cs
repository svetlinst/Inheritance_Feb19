﻿namespace Person
{
    using System;
    public class Child : Person
    {
        public Child(string name, long age) : base(name, age)
        {

        }

        public override long Age
        {
            get => base.Age;
            protected set
            {
                if (value>15)
                {
                    throw new ArgumentException($"Child's age must be less than 15!");
                }
                base.Age = value;
            }
        }
    }
}

