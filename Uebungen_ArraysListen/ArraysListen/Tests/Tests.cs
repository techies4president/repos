using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Kompletttest()
        {
            var ergebnis = Array1.PruefeListe(new List<string> {"Ralf", "Emma", "Hans",""});
            Assert.True(ergebnis);
        }
    }
}
