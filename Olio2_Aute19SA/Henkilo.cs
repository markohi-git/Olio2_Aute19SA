using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olio2_Aute19SA
{
    public class Henkilo
    {
        private Pankkitili tili;

        public Henkilo()
        {
            tili = new Pankkitili();
            tili.setSaldo(10.15);
            tili.setTilinumero("FI234567890");
        }
        public Henkilo(double s)
        {
            tili = new Pankkitili();
            tili.setSaldo(s);
            tili.setTilinumero("FI234567890");
        }
        public Henkilo(string t)
        {
            tili = new Pankkitili();
            tili.setSaldo(10.15);
            tili.setTilinumero(t);
        }
        public Henkilo(double s,string t)
        {
            tili = new Pankkitili();
            tili.setSaldo(s);
            tili.setTilinumero(t);
        }

        public void Saldo()
        {
            //tulosta kaikkien pankkitilien saldot ja tilinumerot
            //lopuksi pankkitilien yhteensä saldo

            Console.WriteLine("Henkilollä on rahaa: " + tili.getSaldo() + " Tilillä " + tili.getTilinumero());
        }

        public void SetPankkitili(string t, double s)
        {
            throw new System.NotImplementedException();
        }
    }
}