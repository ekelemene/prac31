using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Square : Figure
    {
        double side;
        public double Side { get => side; set => side = value; }

        public Square(string name, double side) : base(name)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name}, Сторона: {Side}");
            base.Output();
        }


    }
}
