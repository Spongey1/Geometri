using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Kvadrat
    {
        private double side { get; set; }
        public Kvadrat(double længde)
        {
            side = længde;
        }

        public Kvadrat()
        {

        }

        public double Areal()
        {
            double areal = Math.Pow(side, 2);
            return areal;
        }

        public double Omkreds()
        {
            return 4 * side;
        }
    }
}
