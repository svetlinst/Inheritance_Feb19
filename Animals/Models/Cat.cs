namespace Animals.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Cat : Animal,ISoundProducable
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        
        public string ProduceSound()
        {
            return "Meow meow";
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
