﻿namespace Person
{

    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private long age;

        public virtual long Age
        {
            get => this.age;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Age must be positive!");
                }
                this.age = value;
            }
        }

        public virtual string Name
        {
            get => this.name;
            protected set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                this.name = value;
            }
        }

        public Person(string name, long age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString();
        }
    }
}
