using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paraektezche
{
    public class Program
    {
        static List<Figure> figures = new List<Figure>();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить новую фигуру");
                Console.WriteLine("2. Просмотреть все фигуры");
                Console.WriteLine("3. Просмотреть свойства фигуры");
                Console.WriteLine("4. Редактировать фигуру");
                Console.WriteLine("5. Удалить фигуру");
                Console.WriteLine("6. Вызвать методы фигуры");
                Console.WriteLine("0. Выйти");
                Console.Write("Выберите опцию: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": AddFigure(); break;
                    case "2": ViewFigures(); break;
                    case "3": ViewProperties(); break;
                    case "4": EditFigure(); break;
                    case "5": DeleteFigure(); break;
                    case "6": CallMethod(); break;
                    case "0": return;
                    default: Console.WriteLine("Неверный выбор."); break;
                }
            }
        }

        // Метод для добавления фигуры
        private static void AddFigure()
        {
            Console.WriteLine("\nВыберите тип фигуры:");
            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Квадрат");
            Console.WriteLine("3. Треугольник");
            Console.WriteLine("4. Круг");

            string type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    Console.Write("Введите сторону 1: ");
                    double side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону 2: ");
                    double side2 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Rectangle(side1, side2));
                    break;
                case "2":
                    Console.Write("Введите сторону: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Square(side));
                    break;
                case "3":
                    Console.Write("Введите сторону 1: ");
                    double tSide1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону 2: ");
                    double tSide2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите сторону 3: ");
                    double tSide3 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Triangle(tSide1, tSide2, tSide3));
                    break;
                case "4":
                    Console.Write("Введите радиус: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Circle(radius));
                    break;
                default:
                    Console.WriteLine("Неверный тип фигуры.");
                    break;
            }
        }

        // Метод для просмотра всех фигур
        private static void ViewFigures()
        {
            Console.WriteLine("\nСписок фигур:");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {figures[i].Name}");
            }
        }

        // Метод для просмотра свойств фигуры
        private static void ViewProperties()
        {
            Console.Write("Введите номер фигуры для просмотра: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                figures[index].Print();
            }
            else
            {
                Console.WriteLine("Неверный номер фигуры.");
            }
        }

        // Метод для редактирования фигуры
        private static void EditFigure()
        {
            Console.Write("Введите номер фигуры для редактирования: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                var figure = figures[index];

                if (figure is Rectangle rectangle)
                {
                    Console.Write("Введите новую сторону 1: ");
                    rectangle.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите новую сторону 2: ");
                    rectangle.Side2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Square square)
                {
                    Console.Write("Введите новую сторону: ");
                    square.Side1 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Triangle triangle)
                {
                    Console.Write("Введите новую сторону 1: ");
                    triangle.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите новую сторону 2: ");
                    triangle.Side2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите новую сторону 3: ");
                    triangle.Side3 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Circle circle)
                {
                    Console.Write("Введите новый радиус: ");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Неверный номер фигуры.");
            }
        }

        // Метод для удаления фигуры
        private static void DeleteFigure()
        {
            Console.Write("Введите номер фигуры для удаления: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                figures.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Неверный номер фигуры.");
            }
        }

        // Метод для вызова методов фигуры (площадь и периметр)
        private static void CallMethod()
        {
            Console.Write("Введите номер фигуры для вызова метода: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index >= 0 && index < figures.Count)
            {
                var figure = figures[index];
                Console.WriteLine($"Площадь: {figure.Area()}");
                Console.WriteLine($"Периметр: {figure.Perimeter()}");
            }
            else
            {
                Console.WriteLine("Неверный номер фигуры.");
            }
        }
    }
}
