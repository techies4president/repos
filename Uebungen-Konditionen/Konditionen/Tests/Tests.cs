using Konditionen;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [Category("Gerüsttest")]
        public void Kondition1_HoleEingabe()
        {
            var ergebnis = Kondition1.HoleEingabe(4);
            int erwartet = 4;
            Assert.That(erwartet, Is.EqualTo(ergebnis));
        }
    }
}
