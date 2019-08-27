namespace Mankind
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Student student = new Student(input[0], input[1], input[2]);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Worker worker = new Worker(input[0], input[1], double.Parse(input[2]), double.Parse(input[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message.ToString()}");
            }
        }
    }
}
