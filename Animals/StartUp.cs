namespace Animals
{
    using Animals.Models;
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input!="Beast!")
            {
                try
                {
                    var tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(dog.ToString());
                            break;
                        case "Frog":
                            Frog frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(frog.ToString());
                            break;
                        case "Cat":
                            Cat cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                            Console.WriteLine(cat.ToString());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(tokens[0], int.Parse(tokens[1]));
                            Console.WriteLine(kitten.ToString());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]));
                            Console.WriteLine(tomcat.ToString());
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
