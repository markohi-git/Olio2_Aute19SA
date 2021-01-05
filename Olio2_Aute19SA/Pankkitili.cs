using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olio2_Aute19SA
{
    public class Pankkitili
    {
        private double Saldo;
        private string Tilinro;

        public double getSaldo()
        {
            return Saldo;
        }

        public string getTilinumero()
        {
            return Tilinro;
        }

        public void setSaldo(double s)
        {
            Saldo=s;
        }

        public void setTilinumero(string t)
        {
            Tilinro=t;
        }
    }
}