namespace Person
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            long age = long.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
