using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibraireForme
{
    public class Coordonnees
    {
        private int _x;
        private int _y;

        public Coordonnees(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public Coordonnees()
        {
            new Coordonnees(0, 0);
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "(" + X  + "," + Y + ")";
        }
    }
}