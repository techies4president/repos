using System.Collections.Generic;
using NUnit.Framework;
using Schleifen;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Schleife1")]
        public void Schleife1Test1()
        {
            var ergebnis = Schleife1.Verarbeitung();
            Assert.AreEqual(33,ergebnis);
        }
        [Test, Category("Schleife2")]
        public void Schleife2Test1()
        {
            var ergebnis = Schleife2.Verarbeitung("1\n2\n3\n3\n23\n4\n1\nok");
            Assert.AreEqual(37,ergebnis);
        }
        [Test, Category("Schleife2")]
        public void Schleife2Test2()
        {
            var ergebnis = Schleife2.Verarbeitung("ok");
            Assert.AreEqual(0, ergebnis);
        }
        [Test, Category("Schleife2")]
        public void Schleife2Test3()
        {
            var ergebnis = Schleife2.Verarbeitung("10000000\nok");
            Assert.AreEqual(10000000, ergebnis);
        }
        [Test, Category("Schleife3")]
        public void Schleife3Test1()
        {
            var ergebnis = Schleife3.Verarbeitung(5);
            Assert.AreEqual("5! = 120", ergebnis);
        }
        [Test, Category("Schleife3")]
        public void Schleife3Test2()
        {
            var ergebnis = Schleife3.Verarbeitung(0);
            Assert.AreEqual("0! = 1", ergebnis);
        }
        [Test, Category("Schleife3")]
        public void Schleife3Test3()
        {
            var ergebnis = Schleife3.Verarbeitung(1);
            Assert.AreEqual("1! = 1", ergebnis);
        }
        [Test, Category("Schleife3")]
        public void Schleife3Test4()
        {
            var ergebnis = Schleife3.Verarbeitung(12);
            Assert.AreEqual("12! = 479001600", ergebnis);
        }
        [Test, Category("Schleife5")]
        public void Schleife5Test1()
        {
            var ergebnis = Schleife5.Verarbeitung("9,12,2,66,3,7,41");
            Assert.AreEqual(66, ergebnis);
        }
        [Test, Category("Schleife5")]
        public void Schleife5Test2()
        {
            var ergebnis = Schleife5.Verarbeitung("9,12,2,66,3,66,41");
            Assert.AreEqual(66, ergebnis);
        }
        [Test, Category("Schleife5")]
        public void Schleife5Test3()
        {
            var ergebnis = Schleife5.StringZuInt("9,12,2,66");
            Assert.Contains(66, ergebnis);
        }
        [Test, Category("Schleife5")]
        public void Schleife5Test4()
        {
            var ergebnis = Schleife5.MaxWert(new List<int> {44, 66, 21, 12, 34});
            Assert.AreEqual(66, ergebnis);
        }
    }
}
