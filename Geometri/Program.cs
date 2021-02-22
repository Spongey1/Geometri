using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrat kvadrat1 = new Kvadrat(90);
            Kvadrat kvadrat2 = new Kvadrat(20);

            Console.WriteLine(kvadrat1.Omkreds());
            Console.WriteLine(kvadrat2.Areal());
            Console.ReadKey();
        }
    }
}
