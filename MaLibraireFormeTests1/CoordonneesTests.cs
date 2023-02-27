using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibraireForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibraireForme;

namespace MaLibraireFormeTests1
{
    [TestClass()]
    public class CoordonneesTests
    {
        [TestMethod()]
        public void TestConstructors()
        {
            Coordonnees c1 = new Coordonnees();
            Coordonnees c2 = new Coordonnees(1, 2);
            Assert.AreEqual(c1.X, 0);
            Assert.AreEqual(c1.Y, 0);

            Assert.AreEqual(c2.X, 1);
            Assert.AreEqual(c2.Y, 2);
        }

        [TestMethod()]
        public void TestSetter()
        {
            Coordonnees c1 = new Coordonnees();
            c1.X = 2;

            Assert.AreEqual(c1.X, 2);
        }

        [TestMethod()]
        public void TestToString()
        {
            Coordonnees c1 = new Coordonnees(2,3);

            Assert.AreEqual(c1.ToString(), "(2,3)");
        }

    }
}