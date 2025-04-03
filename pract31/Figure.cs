using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    /// <summary>
    /// асбтрактный класс
    /// </summary>
     abstract class Figure
    {
        /// <summary>
        /// поле имени
        /// </summary>
        string name;
        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="name"></param>
        public Figure(string name) 
        {
            this.Name = name;
        }
        /// <summary>
        /// свйоство
        /// </summary>
        public string Name { get => name; set => name = value; }

        /// <summary>
        /// абстрактные методы Площадь  и Периметр 
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        public abstract double Perimeter();
        /// <summary>
        /// Виртуальный метод вывод
        /// </summary>
        public virtual void Output()
        {
            Console.WriteLine($"Фигура: {Name}");
            Console.WriteLine($"Площадь: {Area()}");
            Console.WriteLine($"Периметр: {Perimeter()}");
        }
    }
}
