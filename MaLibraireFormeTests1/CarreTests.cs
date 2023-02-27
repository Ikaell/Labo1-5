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
    public class CarreTests
    {
        [TestMethod()]
        public void TestConstructors()
        {
            Carre c1 = new Carre();
            Carre c2 = new Carre(2);

            Assert.AreEqual(c1.SideLength, 0);
            Assert.AreEqual(c1.C.X, 0);
            Assert.AreEqual(c1.C.Y, 0);

            Assert.AreEqual(c2.SideLength, 2);
            Assert.AreEqual(c2.C.X, 0);
            Assert.AreEqual(c2.C.Y, 0);

            c2.C.X = 1;

            Assert.AreEqual(c2.C.X, 1);
        }

        [TestMethod()]
        public void TestSetter()
        {
            Carre c1 = new Carre();
            c1.SideLength = 2;

            Assert.AreEqual(c1.SideLength, 2);
        }

        [TestMethod()]
        public void TestToString()
        {
            Carre c1 = new Carre(3);

            Assert.AreEqual(c1.ToString(), "(0,0)3 NbSommets : 4");
        }

        [TestMethod()]
        public void TestEstDans()
        {
            Carre c1 = new Carre(3);
            Coordonnees coord = new Coordonnees(3, 4);

            c1.C.X = 2;
            c1.C.Y = 3;

            Assert.IsTrue(c1.CoordonneeEstDans(coord));
        }

        [TestMethod()]
        public void TestEstPasDans()
        {
            Carre c1 = new Carre(3);
            Coordonnees coord1 = new Coordonnees(0, 0);
            Coordonnees coord2 = new Coordonnees(10, 12);

            c1.C.X = 2;
            c1.C.Y = 3;

            Assert.IsFalse(c1.CoordonneeEstDans(coord1));
            Assert.IsFalse(c1.CoordonneeEstDans(coord2));
        }

        [TestMethod()]
        public void TestGetterNbSommets()
        {
            Carre c1 = new Carre(2);

            Assert.AreEqual(c1.NbSommets, 4);
        }
    }
}
