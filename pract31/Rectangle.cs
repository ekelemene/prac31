using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Rectangle : Figure
    {
        double side1;
        double side2;

        public Rectangle(string name, double side1, double side2) :base (name)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public override double Area() 
        {
            return Side1 * Side2;
        }

        public override double Perimeter() 
        {
            return 2 * (Side1 + Side2);
        }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name}, Сторона1: {Side1}, Сторона2: {Side2}");
            base.Output();
        }
        public static Rectangle Enter()
        {
            Console.Clear();
            Console.Write("Введите название фигуры: ");
            string name = Console.ReadLine();
            Console.Write("Введите первую сторону: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону: ");
            double side2 = double.Parse(Console.ReadLine());
            return new Rectangle(name, side1, side2);
        }
    }
}
