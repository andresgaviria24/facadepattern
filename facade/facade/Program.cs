using System;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFacade facade = new CalculateFacade();
            Console.WriteLine("Fontanero - Valor final en COP $" + facade.Operation(5,1));

            Console.WriteLine("Carpintero - Valor final en COP $" + facade.Operation(8, 2));

            Console.WriteLine("Electricista - Valor final en COP $" + facade.Operation(2, 3));
        }
    }
}

