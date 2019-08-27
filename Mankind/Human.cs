namespace Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => this.firstName;
            protected set
            {
                if (!Char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
                }
                if (value.Length<=3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(this.firstName)}");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName;
            protected set
            {
                if (!Char.IsUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(this.lastName)}");
                }
                this.lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            return sb.ToString();
        }
    }
}
