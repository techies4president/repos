using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Schleife4;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Methodentest")]
        public void Test_ErstellePruefzahl_1()
        {
            var ergebnis = Schleife4.Schleife4.ErstellePruefzahl();
            Assert.IsTrue(ergebnis >=1&&ergebnis <=10);
        }
        [Test, Category("Methodentest")]
        public void Test_PruefeEingabe_1()
        {
            var versuche = 3;
            var pruefzahl = 4;
            var ergebnis = Schleife4.Schleife4.PruefeEingabe(ref versuche, 6, pruefzahl);
            Assert.AreEqual(3, ergebnis);
        }
        [Test, Category("Methodentest")]
        public void Test_PruefeEingabe_2()
        {
            var versuche = 0;
            var pruefzahl = 4;
            var ergebnis = Schleife4.Schleife4.PruefeEingabe(ref versuche, 4, pruefzahl);
            Assert.AreEqual(0, ergebnis);
        }
        [Test, Category("Methodentest")]
        public void Test_PruefeEingabe_3()
        {
            var versuche = 0;
            var pruefzahl = 4;
            var ergebnis = Schleife4.Schleife4.PruefeEingabe(ref versuche, 5, pruefzahl);
            Assert.AreEqual(0, ergebnis);
        }
    }
}
