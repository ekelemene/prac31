using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Circle : Figure
    {
        double radius;
        public double Radius { get => radius; set => radius = value; }

        public Circle(string name, double radius):base(name)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name}, Радиус: {Radius}");
            base.Output();
        }
    }
}
