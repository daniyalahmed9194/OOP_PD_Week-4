using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    internal class Angle
    {
        public Angle() { }
        public Angle(int Degree, float Minutes, char Direction)
        { 
            this.Degree = Degree;
            this.Minutes = Minutes;
            this.Direction = Direction;
        }
        public int Degree;
        public float Minutes;
        public char Direction;

        public string Display()
        {
            string b, c, d;
            b =  Degree.ToString();
            c = Minutes.ToString();
            d = Direction.ToString();
            string a =b+"°"+c+"'"+d;
            return a;
        }
    }
}
