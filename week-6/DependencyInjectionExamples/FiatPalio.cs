using System;

namespace DependencyInjectionExamples
{
    public class FiatPalio : ICar
    {
        public void Start()
        {
            Console.WriteLine("FiatPalio Araba Çalıştı");
        }

        public void ShotDown()
        {
            Console.WriteLine("FiatPalio Arabayı istop ettik");
        }

        public void GoForward()
        {
            Console.WriteLine("FiatPalio İleri Gidiyor");
        }


        public void GoBack()
        {
            Console.WriteLine("FiatPalio Geri Gidiyor");
        }
        public void Stop()
        {
            Console.WriteLine("FiatPalio Durdu");
        }
        public void ParkEt()
        {
            Console.WriteLine("FiatPalio ParkEt");
        }
    }
}
