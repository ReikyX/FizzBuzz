namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)              //Zählt i von 1 bis kleiner gleich 100 mit jedem weiteren durchlauf erhöht sich die Zahl i um 1
            {
                if (i % 3 == 0 && i % 5 == 0)           //Zahl i ist durch 3 und durch 5 teilbar
                    Console.WriteLine("\nFizzBuzz");    //Gibt dann FizzBuzz aus
                else if (i % 3 == 0)                    //Zahl i ist durch 3 teilbar
                    Console.WriteLine("\nFizz");        //Gibt dann Fizz aus
                else if (i % 5 == 0)                    //Zahl i ist durch 5 teilbar
                    Console.WriteLine("\nBuzz");        //Gibt dann Buzz aus
                else                                    //Sonst
                    Console.WriteLine($"\n{i}");        //Gibt die aktuelle Zahl i aus
            }
        }
    }
}
