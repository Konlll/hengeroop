using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Henger
    {
        double magassag, sugar;
        static double szuletesSzamlalo;

        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo += 1;
        }

        public double Magassag { get => magassag; }
        public double Sugar { get => sugar; }
        public static double SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
        {
            return Math.Round(sugar * sugar * Math.PI * magassag, 2);
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {this.Terfogat()}; sugár: {this.sugar}; magasság: {this.magassag}";
        }
    }
}
