namespace Mankind
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => this.facultyNumber;
            private set
            {
                if (value.Length<5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) :  base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            return sb.ToString();
        }
    }
}
