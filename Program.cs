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
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new figure");
                Console.WriteLine("2. View all figures");
                Console.WriteLine("3. View properties of a figure");
                Console.WriteLine("4. Edit a figure");
                Console.WriteLine("5. Delete a figure");
                Console.WriteLine("6. Call method of a figure");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddFigure();
                        break;
                    case "2":
                        ViewFigures();
                        break;
                    case "3":
                        ViewProperties();
                        break;
                    case "4":
                        EditFigure();
                        break;
                    case "5":
                        DeleteFigure();
                        break;
                    case "6":
                        CallMethod();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            Console.Read();
        }

        private static void AddFigure()
        {
            Console.WriteLine("\nSelect figure type:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Circle");
            string type = Console.ReadLine();

            switch (type)
            {
                case "1":
                    Console.Write("Enter side1: ");
                    double side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side2: ");
                    double side2 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Rectangle(side1, side2));
                    break;
                case "2":
                    Console.Write("Enter side: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Square(side));
                    break;
                case "3":
                    Console.Write("Enter side1: ");
                    double tSide1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side2: ");
                    double tSide2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter side3: ");
                    double tSide3 = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Triangle(tSide1, tSide2, tSide3));
                    break;
                case "4":
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    figures.Add(new Circle(radius));
                    break;
                default:
                    Console.WriteLine("Invalid figure type.");
                    break;
            }
        }

        private static void ViewFigures()
        {
            Console.WriteLine("\nList of figures:");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {figures[i].Name}");
            }
        }

        private static void ViewProperties()
        {
            Console.Write("Enter the figure number to view: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < figures.Count)
            {
                figures[index].Print();
            }
            else
            {
                Console.WriteLine("Invalid figure number.");
            }
        }

        private static void EditFigure()
        {
            Console.Write("Enter the figure number to edit: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < figures.Count)
            {
                var figure = figures[index];
                if (figure is Rectangle rectangle)
                {
                    Console.Write("Enter new side1: ");
                    rectangle.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side2: ");
                    rectangle.Side2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Square square)
                {
                    Console.Write("Enter new side: ");
                    square.Side1 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Triangle triangle)
                {
                    Console.Write("Enter new side1: ");
                    triangle.Side1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side2: ");
                    triangle.Side2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new side3: ");
                    triangle.Side3 = Convert.ToDouble(Console.ReadLine());
                }
                else if (figure is Circle circle)
                {
                    Console.Write("Enter new radius: ");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Invalid figure number.");
            }
        }

        private static void DeleteFigure()
        {
            Console.Write("Enter the figure number to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < figures.Count)
            {
                figures.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid figure number.");
            }
        }

        private static void CallMethod()
        {
            Console.Write("Enter the figure number to call method: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            if (index >= 0 && index < figures.Count)
            {
                var figure = figures[index];
                Console.WriteLine($"Area: {figure.Area()}");
                Console.WriteLine($"Perimeter: {figure.Perimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid figure number.");
            }
        }

    }
}
