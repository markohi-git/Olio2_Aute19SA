using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio2_Aute19SA
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo h = new Henkilo();
            h.SetPankkitili("FI9876546789",456);

            h.Saldo();

            Console.ReadKey();
        }
    }
}
