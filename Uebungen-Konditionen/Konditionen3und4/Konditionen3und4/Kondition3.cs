using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konditionen3und4
{
    public class Kondition3
    {
        internal static int Verarbeitung(string eingabe1, string eingabe2)
        {
            return VergleicheEingaben(eingabe1, eingabe2);
        }
        internal static int VergleicheEingaben(string eingabe1, string eingabe2)
        {
            var int1 = Convert.ToInt32(eingabe1);
            var int2 = Convert.ToInt32(eingabe2);
            if (int1 > int2)
            {
                return (1);
            }
            else if (int1 < int2)
            {
                return (2);
            }
            else
            {
                return (3);
            }
        }
    }

}
