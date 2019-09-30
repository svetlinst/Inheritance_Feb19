namespace Animals.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Tomcat:Cat,ISoundProducable
    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {

        }

        public new string ProduceSound()
        {
            return "MEOW";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.Append($"{this.ProduceSound()}");
            return sb.ToString();
        }
    }
}
