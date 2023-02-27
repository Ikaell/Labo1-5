using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibraireForme
{
    public class Rectangle : Forme, ISommets
    {
        private int _length;
        private int _width;

        public Rectangle() : base()
        {
            _length = 0;
            _width = 0;
        }

        public Rectangle(int length, int width) : base()
        {
            _length = length;
            _width = width;
        }

        public int Lenght
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Width    
        {
            get { return _width; }
            set { _width = value; }
        }

        public override string ToString()
        {
            return base.C.ToString() + "(" + Lenght + "," + _width + ")" + " NbSommets : " + NbSommets;
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }

        public override bool CoordonneeEstDans(Coordonnees p)
        {
            if (this.C.X + this.Lenght < p.X || this.C.X > p.X)
                return false;
            if (this.C.Y + this.Width < p.Y || this.C.Y > p.Y)
                return false;

            return true;
        }

        public int NbSommets
        {
            get { return 4; }
        }
    }
}
