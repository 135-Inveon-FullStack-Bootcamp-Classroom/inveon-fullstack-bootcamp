using System;

namespace DP_Exp
{
    public class Terorist : IPlayer
    {
        private ITeroristGun _gun;

        public Terorist(ITeroristGun gun)
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
