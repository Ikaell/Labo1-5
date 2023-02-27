using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibraireForme
{
    public abstract class Forme : IEstDans
    {
        private Coordonnees _c;

        public Forme()
        {
            _c = new Coordonnees();
        }

        public Coordonnees C
        {
            get { return _c; }
            set { _c = value; }
        }

        public abstract void Affiche();
        public abstract bool CoordonneeEstDans(Coordonnees p);
    }
}
