using System.Collections;
namespace Schleifen
{
    public class Schleife1
    {
        public static int Verarbeitung()
        {
            return ZaehleTeilbare();
        }
        internal static int ZaehleTeilbare()
        {
            var i = 1;
            var teilbare = new ArrayList();
            while (i <= 100)
            {
                var rest = i % 3;
                if (rest == 0)
                {
                    teilbare.Add(i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return teilbare.Count;
        }
    }
}