using froehlichezahlen;
using NUnit.Framework;

namespace tests
{
    [TestFixture]
    public class TestsFroehlichezahlen
    {
        [Test]
        public void Test_Gesamttest()
        {
            var ergebnis = Verarbeitung.StarteRechnung(4);
            Assert.AreEqual(false, ergebnis);
            var ergebnis2 = Verarbeitung.StarteRechnung(19);
            Assert.AreEqual(true, ergebnis2);
            var ergebnis3 = Verarbeitung.StarteRechnung(7);
            Assert.AreEqual(true, ergebnis3);
            var ergebnis4 = Verarbeitung.StarteRechnung(20);
            Assert.AreEqual(false, ergebnis4);
            var ergebnis5 = Verarbeitung.StarteRechnung(998);
            Assert.AreEqual(true, ergebnis5);
        }

        [Test]
        [Category("Gerüsttest")]
        public void Test_HoleIntArray()
        {
            var ergebnis = Verarbeitung.HoleIntArray(887932);
            int[] beispiel = {8, 8, 7, 9, 3, 2};
            Assert.That(beispiel, Is.EqualTo(ergebnis));
        }

        [Test]
        public void Test_PotenziereIntArray()
        {
            int[] testarray = {2, 0};
            var ergebnis = Verarbeitung.PotenziereIntArray(testarray);
            Assert.AreEqual(4, ergebnis);
            int[] testarray2 = {4, 2};
            var ergebnis2 = Verarbeitung.PotenziereIntArray(testarray2);
            Assert.AreEqual(20, ergebnis2);
        }

        [Test]
        public void Test_PruefeFroehlich()
        {
            var obFroehlich = Verarbeitung.PruefeFroehlich(4, false);
            Assert.AreEqual(false, obFroehlich);
            var obFroehlich2 = Verarbeitung.PruefeFroehlich(9, false);
            Assert.AreEqual(false, obFroehlich2);
            var obFroehlich3 = Verarbeitung.PruefeFroehlich(1, false);
            Assert.AreEqual(true, obFroehlich3);
        }

        [Test]
        public void Test_PruefeLoesung()
        {
            var obFroehlich = Verarbeitung.PruefeLoesung(89, false);
            Assert.AreEqual(false, obFroehlich);
            var obFroehlich2 = Verarbeitung.PruefeLoesung(4, false);
            Assert.AreEqual(true, obFroehlich2);
            var obFroehlich3 = Verarbeitung.PruefeLoesung(1, false);
            Assert.AreEqual(true, obFroehlich3);
        }
    }
}