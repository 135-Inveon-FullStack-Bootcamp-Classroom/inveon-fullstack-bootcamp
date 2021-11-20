using System;

namespace DP_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("silah seç");
            int silahNo;
            IGun gun;

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

            var player = new Player(gun);
            player.AtesEt();
        }
    }
}
