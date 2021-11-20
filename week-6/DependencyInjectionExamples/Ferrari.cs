using System;

namespace DependencyInjectionExamples
{
    class Ferrari : ICar
    {
        public void Start()
        {
            Console.WriteLine("Ferrari Start");
        }

        public void ShotDown()
        {

            Console.WriteLine("Ferrari ShotDown");
        }

        public void GoForward()
        {

            Console.WriteLine("Ferrari GoForward");
        }

        public void GoBack()
        {

            Console.WriteLine("Ferrari GoBack");
        }

        public void Stop()
        {

            Console.WriteLine("Ferrari Stop");
        }

        public void ParkEt()
        {

            Console.WriteLine("Ferrari ParkEt");
        }
    }
}
