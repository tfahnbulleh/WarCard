using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCard
{
    public class Card
    {
        private int _face; //face of the card
        private string _suite; //card suite

        //constuctor
        public Card(int face, string suite)
        {
            this._face = face;
            this._suite = suite;
        }

        public int Face
        {
            get { return this._face; }
        }

        //overide ToString method
        public override string ToString()
        {
            return _suite.ToLower()+_face;
        }
    }
}
