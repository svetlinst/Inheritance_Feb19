namespace Animals.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Kitten:Cat,ISoundProducable
    {
        public Kitten(string name, int age) : base(name, age, "Female")
        {

        }

        public new string ProduceSound()
        {
            return "Meow";
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
