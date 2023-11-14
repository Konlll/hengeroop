using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double magassag, double sugar, double fajsuly) : base(magassag, sugar)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double magassag, double sugar) : base(magassag, sugar)
        {
            this.fajsuly = 7.87;
        }

        public double GetFajsuly { get => fajsuly; }
        public double Suly { get => 0; }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {this.Terfogat()}; sugár: {base.Sugar}; magasság: {base.Magassag}; fajsúly: {this.fajsuly}";
        }
    }
}
