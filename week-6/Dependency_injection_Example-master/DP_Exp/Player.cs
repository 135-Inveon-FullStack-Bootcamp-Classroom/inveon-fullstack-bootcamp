using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Exp
{
    public class Player
    {
        private IGun _gun;

        public Player(IGun gun)
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
