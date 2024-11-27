namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("\nFizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("\nFizz");
                else if (i % 5 == 0)
                    Console.WriteLine("\nBuzz");
                else 
                    Console.WriteLine($"\n{i}");
            }
        }
    }
}
