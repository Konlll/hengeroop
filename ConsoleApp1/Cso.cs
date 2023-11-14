using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cso : Henger
    {
        double falVastagsag;
        public Cso(double magassag, double sugar, double falVastagsag) : base(magassag, sugar)
        {
            this.falVastagsag = falVastagsag;
        }
        public Cso(double magassag, double sugar) : base(magassag, sugar)
        {
            this.falVastagsag = 1;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            double terfogat1 = Math.Round(Math.PI * base.Sugar * base.Sugar * base.Magassag, 2);
            double terfogat2 = Math.Round(Math.PI * Math.Pow(base.Sugar - this.falVastagsag, 2) * base.Magassag, 2);
            return Math.Round(terfogat1 - terfogat2, 2);
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {this.Terfogat()}; sugár: {base.Sugar}; magasság: {base.Magassag}; falvastagság: {this.falVastagsag}";
        }

    }
}
