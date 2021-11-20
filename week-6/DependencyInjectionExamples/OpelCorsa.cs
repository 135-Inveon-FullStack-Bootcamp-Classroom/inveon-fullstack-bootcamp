using System;

namespace DependencyInjectionExamples
{
    public class OpelCorsa: ICar
    {
        public void Start()
        {
            Console.WriteLine("OpelCorsa Araba Çalıştı");
        }

        public void ShotDown()
        {
            Console.WriteLine("OpelCorsa Arabayı istop ettik");
        }

        public void GoForward()
        {
            Console.WriteLine("OpelCorsa İleri Gidiyor");
        }


        public void GoBack()
        {
            Console.WriteLine("OpelCorsa Geri Gidiyor");
        }
        public void Stop()
        {
            Console.WriteLine("OpelCorsa Durdu");
        }
        public void ParkEt()
        {
            Console.WriteLine("OpelCorsa ParkEt");
        }
    }
}
