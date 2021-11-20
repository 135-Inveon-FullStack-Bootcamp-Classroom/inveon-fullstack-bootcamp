using System;

namespace DependencyInjectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var palio = new FiatPalio();
            var corsa = new OpelCorsa();
            var ferrari = new Ferrari();

            var driver = new Driver(ferrari);

            driver.Drive();
            Console.ReadKey();
        }


    }
}
