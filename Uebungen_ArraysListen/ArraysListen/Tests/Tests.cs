using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArraysListen;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test, Category("Array1")]
        public void Array1_PruefeListe()
        {
            var ergebnis = Array1.PruefeListe(new List<string> {"Ralf", "Emma", "Hans",""});
            Assert.True(ergebnis);
        }
        [Test, Category("Array1")]
        public void Array1_VerarbeiteListe1()
        {
            var eingabe = new List<string> { "Ralf", "Emma", "Hans", "" };
            var ergebnis = Array1.VerarbeiteListe(eingabe);
            Assert.AreEqual("Ralf, Emma und 1 weitere mögen deinen Post",ergebnis);
        }
        [Test, Category("Array1")]
        public void Array1_VerarbeiteListe2()
        {
            var eingabe = new List<string> { "Ralf", "Emma", "" };
            var ergebnis = Array1.VerarbeiteListe(eingabe);
            Assert.AreEqual("Ralf und Emma mögen deinen Post", ergebnis);
        }
        [Test, Category("Array1")]
        public void Array1_VerarbeiteListe3()
        {
            var eingabe = new List<string> { "Ralf", "" };
            var ergebnis = Array1.VerarbeiteListe(eingabe);
            Assert.AreEqual("Ralf mag deinen Post", ergebnis);
        }
        [Test, Category("Array1")]
        public void Array1_VerarbeiteListe4()
        {
            var eingabe = new List<string> { "" };
            var ergebnis = Array1.VerarbeiteListe(eingabe);
            Assert.AreEqual("", ergebnis);
        }
        [Test, Category("Array2")]
        public void Array2_Gesamttest()
        {
            var ergebnis = Array2.Verarbeitung("David");
            Assert.AreEqual("Divad", ergebnis);
        }
        [Test, Category("Array2")]
        public void Array2_StringZuArray1()
        {
            var charList = new List<char> {'d','a','v','i','d'};
            var ergebnis = Array2.StringZuListe("David");
            Assert.AreEqual(charList, ergebnis);
        }
        
        [Test, Category("Array3")]
        public void Array3_PruefeUndListe()
        {
            var liste = new List<int> {1,2,3,4};
            var eingabe = Convert.ToInt32(2);
            Array3.PruefeUndListe(liste, eingabe);
            var ergebnis = liste.Count;
            Assert.AreEqual(4, ergebnis);
        }

        [Test, Category("Array3")]
        public void Array3_Ausgabe()
        {
            var unsortiert = new List<int> {1, 3, 12, 8};
            var sortiert = new List<int> {1,3,8,12};
            var ergebnis = Array3.Ausgabe(unsortiert);
            Assert.AreEqual(sortiert, ergebnis);
        }
        [Test, Category("Array4")]
        public void Array4_Ausgabe1()
        {
            var eingabe = new List<int> { 1, 3, 8, 12 };
            var vergleichsListe = new List<int> { 1, 3, 8, 12 };
            var ergebnis = Array4.Ausgabe(eingabe);
            Assert.AreEqual(vergleichsListe, ergebnis);
        }
        [Test, Category("Array4")]
        public void Array4_Ausgabe2()
        {
            var eingabe = new List<int> { };
            var vergleichsListe = new List<int> { };
            var ergebnis = Array4.Ausgabe(eingabe);
            Assert.AreEqual(vergleichsListe, ergebnis);
        }
        [Test, Category("Array4")]
        public void Array4_Ausgabe3()
        {
            var eingabe = new List<int> { 1, 3, 3, 12 };
            var vergleichsListe = new List<int> { 1, 3, 12 };
            var ergebnis = Array4.Ausgabe(eingabe);
            Assert.AreEqual(vergleichsListe, ergebnis);
        }
        [Test, Category("Array4")]
        public void Array4_Ausgabe4()
        {
            var eingabe = new List<int> { 1, 8,8,8 };
            var vergleichsListe = new List<int> { 1, 8 };
            var ergebnis = Array4.Ausgabe(eingabe);
            Assert.AreEqual(vergleichsListe, ergebnis);
        }

    }
}
