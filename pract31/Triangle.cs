using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Triangle : Figure
    {
        double side1;
        double side2;
        double side3;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Side3 { get => side3; set => side3 = value; }

        public Triangle(string name, double side1, double side2, double side3) :base(name)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public override double Area()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override double Perimeter()
        {
            return Side1 * Side2 * Side3;
        }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name}, Сторона1: {Side1}, Сторона2: {Side2}, Сторона3: {Side3}");
            base.Output();

        }
    }
}
