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
    public class RectangleTests
    {
        [TestMethod()]
        public void TestConstructors()
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(3, 2);

            Assert.AreEqual(r1.Lenght, 0);
            Assert.AreEqual(r1.Width, 0);
            Assert.AreEqual(r1.C.X, 0);
            Assert.AreEqual(r1.C.Y, 0);

            Assert.AreEqual(r2.Lenght, 3);
            Assert.AreEqual(r2.Width, 2);
            Assert.AreEqual(r2.C.X, 0);
            Assert.AreEqual(r2.C.Y, 0);

            r2.C.Y = 1;

            Assert.AreEqual(r2.C.Y, 1);
        }

        [TestMethod()]
        public void TestSetter()
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 2;
            r1.Lenght = 3;

            Assert.AreEqual(r1.Lenght, 3);
            Assert.AreEqual(r1.Width, 2);
        }

        [TestMethod()]
        public void TestToString()
        {
            Rectangle r1 = new Rectangle(4, 2);

            Assert.AreEqual(r1.ToString(), "(0,0)(4,2) NbSommets : 4");
        }

        [TestMethod()]
        public void TestEstDans()
        {
            Rectangle r1 = new Rectangle(4,3);
            Coordonnees coord = new Coordonnees(3, 4);

            r1.C.X = 2;
            r1.C.Y = 3;

            Assert.IsTrue(r1.CoordonneeEstDans(coord));
        }

        [TestMethod()]
        public void TestEstPasDans()
        {
            Rectangle r1 = new Rectangle(4, 3);
            Coordonnees coord1 = new Coordonnees(0, 0);
            Coordonnees coord2 = new Coordonnees(10, 12);

            r1.C.X = 2;
            r1.C.Y = 3;

            Assert.IsFalse(r1.CoordonneeEstDans(coord1));
            Assert.IsFalse(r1.CoordonneeEstDans(coord2));
        }

        [TestMethod()]
        public void TestGetterNbSommets()
        {
            Rectangle r1 = new Rectangle(3, 2);

            Assert.AreEqual(r1.NbSommets, 4);
        }
    }
}
