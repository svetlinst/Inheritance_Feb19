namespace Animals.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }

        protected int Age
        {
            get => this.age;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        protected virtual string Gender
        {
            get => this.gender;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
