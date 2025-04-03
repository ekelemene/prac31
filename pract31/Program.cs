using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract31
{
    class Program
    {
        static List<Figure> figures = new List<Figure>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Просмотреть все фигуры");
                Console.WriteLine("3. Редактировать фигуру");
                Console.WriteLine("4. Удалить фигуру");
                Console.WriteLine("5. Выход");

                Console.Write("Выберите опцию: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddFigure();
                        break;
                    case 2:
                        DisplayFigures();
                        break;
                    case 3:
                        EditFigure();
                        break;
                    case 4:
                        DeleteFigure();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }

            }
        }

    }
}

