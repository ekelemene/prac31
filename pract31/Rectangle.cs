using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Rectangle : Figure
    {
        int side1;
        int side2;

        public Rectangle(int side1, int side2) 
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }

        public override double Area() 
        {
            return Side1 * Side2;
        }

        public override double Perimeter() { }

    }
}
