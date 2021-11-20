using System;

namespace DP_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            FightAsCounter();
            //FightAsTerorist();
        }

        private static void FightAsTerorist()
        {
            //...
        }

        private static void FightAsCounter()
        {
            Console.WriteLine("silah seç");
            int silahNo;

            ICounterGun gun;

            silahNo = int.Parse(Console.ReadLine());

            if (silahNo == 1)
            {
                gun = new Taramali();
            }
            else if (silahNo == 2)
            {
                gun = new Pompali();
            }
            else
            {
                gun = new Deagle();
            }

            var player = new Counter(gun);
            player.AtesEt();
        }
    }
}
