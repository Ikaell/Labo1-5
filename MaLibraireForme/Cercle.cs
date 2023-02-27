using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibraireForme
{
    public class Cercle : Forme
    {
        private float _radiusLength;

        public Cercle() : base()
        {
            _radiusLength = 0;
        }

        public Cercle(float radiusLength) : base()
        {
            _radiusLength = radiusLength;
        }

        public float RadiusLength
        {
            get { return _radiusLength; }
            set { _radiusLength = value; }
        }

        public override string ToString()
        {
            return base.C.ToString() + RadiusLength;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (this.C.X + this.RadiusLength < p.X || this.C.X - this.RadiusLength > p.X)
                return false;
            if (this.C.Y + this.RadiusLength < p.Y || this.C.Y - this.RadiusLength > p.Y)
                return false;

            return true;
        }
    }
}
