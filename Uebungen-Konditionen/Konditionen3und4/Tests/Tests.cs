using System.Data.Odbc;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using Konditionen3und4;
namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Tests_Kondition3")]
        public void Querformat()
        {
            var ergebnis = Kondition3.Verarbeitung("3","5");
            Assert.AreEqual(2,ergebnis);
        }
        [Test, Category("Tests_Kondition3")]
        public void Hochformat()
        {
            var ergebnis = Kondition3.Verarbeitung("800", "600");
            Assert.AreEqual(1, ergebnis);
        }
        [Test, Category("Tests_Kondition3")]
        public void Quadrat()
        {
            var ergebnis = Kondition3.Verarbeitung("42", "42");
            Assert.AreEqual(3, ergebnis);
        }

        [Test, Category("Tests_Kondition4")]
        public void Ok()
        {
            var ergebnis = Kondition4.Verarbeitung("30", "30");
            Assert.AreEqual("OK",ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber00()
        {
            var ergebnis = Kondition4.Verarbeitung("54", "50");
            Assert.AreEqual("Glück gehabt! 0 Punkte.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber01()
        {
            var ergebnis = Kondition4.Verarbeitung("56", "50");
            Assert.AreEqual("1 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber02()
        {
            var ergebnis = Kondition4.Verarbeitung("60", "50");
            Assert.AreEqual("2 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber03()
        {
            var ergebnis = Kondition4.Verarbeitung("66", "50");
            Assert.AreEqual("3 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber04()
        {
            var ergebnis = Kondition4.Verarbeitung("70", "50");
            Assert.AreEqual("4 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber05()
        {
            var ergebnis = Kondition4.Verarbeitung("78", "50");
            Assert.AreEqual("5 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber06()
        {
            var ergebnis = Kondition4.Verarbeitung("81", "50");
            Assert.AreEqual("6 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber07()
        {
            var ergebnis = Kondition4.Verarbeitung("87", "50");
            Assert.AreEqual("7 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber08()
        {
            var ergebnis = Kondition4.Verarbeitung("92", "50");
            Assert.AreEqual("8 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber09()
        {
            var ergebnis = Kondition4.Verarbeitung("95", "50");
            Assert.AreEqual("9 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber10()
        {
            var ergebnis = Kondition4.Verarbeitung("100", "50");
            Assert.AreEqual("10 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber11()
        {
            var ergebnis = Kondition4.Verarbeitung("105", "50");
            Assert.AreEqual("11 Punkte kassiert.", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber12()
        {
            var ergebnis = Kondition4.Verarbeitung("110", "50");
            Assert.AreEqual("12 Punkte kassiert.\nFührerschein wird entzogen", ergebnis);
        }
        [Test, Category("Tests_Kondition4")]
        public void Drueber14()
        {
            var ergebnis = Kondition4.Verarbeitung("120", "50");
            Assert.AreEqual("14 Punkte kassiert.\nFührerschein wird entzogen", ergebnis);
        }
    }
}