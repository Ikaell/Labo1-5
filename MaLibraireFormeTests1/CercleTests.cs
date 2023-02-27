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
    public class CercleTests
    {
        [TestMethod()]
        public void TestConstructors()
        {
            Cercle c1 = new Cercle();
            Cercle c2 = new Cercle(2);

            Assert.AreEqual(c1.RadiusLength, 0);
            Assert.AreEqual(c1.C.X, 0);
            Assert.AreEqual(c1.C.Y, 0);

            Assert.AreEqual(c2.RadiusLength, 2);
            Assert.AreEqual(c2.C.X, 0);
            Assert.AreEqual(c2.C.Y, 0);

            c2.C.X = 1;

            Assert.AreEqual(c2.C.X, 1);
        }

        [TestMethod()]
        public void TestSetter()
        {
            Cercle c1 = new Cercle();
            c1.RadiusLength = 2;

            Assert.AreEqual(c1.RadiusLength, 2);
        }

        [TestMethod()]
        public void TestToString()
        {
            Cercle c1 = new Cercle(4);

            Assert.AreEqual(c1.ToString(), "(0,0)4");
        }

        [TestMethod()]
        public void TestEstDans()
        {
            Cercle c1 = new Cercle(3);
            Coordonnees coord1 = new Coordonnees(4, 4);
            Coordonnees coord2 = new Coordonnees(5, 3);

            c1.C.X = 2;
            c1.C.Y = 3;

            Assert.IsTrue(c1.CoordonneeEstDans(coord1));
            Assert.IsTrue(c1.CoordonneeEstDans(coord2));
        }

        [TestMethod()]
        public void TestEstPasDans()
        {
            Cercle c1 = new Cercle(3);
            Coordonnees coord = new Coordonnees(10, 12);

            c1.C.X = 2;
            c1.C.Y = 3;

            Assert.IsFalse(c1.CoordonneeEstDans(coord));
        }
    }
}
