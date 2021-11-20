using System;

namespace DP_Exp
{
    public class Counter : IPlayer
    {
        private ICounterGun _gun;

        public Counter(ICounterGun gun)
        {
            _gun = gun;
        }

        public void AtesEt()
        {
            Console.WriteLine("PAT");
            _gun.Atis();

        }

        public void HareketEt()
        {
            Console.WriteLine("Yürü");
        }

    }
}
