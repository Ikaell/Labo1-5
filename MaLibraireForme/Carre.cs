using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaLibraireForme
{
    public class Carre : Forme, ISommets
    {
        private int _sideLength;

        public Carre() : base()
        {
            _sideLength = 0;
        }

        public Carre(int sideLength) : base()
        {
            _sideLength = sideLength;
        }

        public int SideLength
        {
            get { return _sideLength; }
            set { _sideLength = value; }
        }

        public override string ToString()
        {
            return base.C.ToString() + SideLength + " NbSommets : " + NbSommets;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (this.C.X + this.SideLength < p.X || this.C.X > p.X)
                return false;
            if(this.C.Y + this.SideLength < p.Y || this.C.Y > p.Y)
                return false;

            return true;
        }

        public int NbSommets
        {
            get { return 4; }
        }
    }
}
