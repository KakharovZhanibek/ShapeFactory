using FactoryPatternDemo.folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Client().Main();
            Console.WriteLine("Выберите фигуру");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Прямоугольник");
            Console.WriteLine("3. Круг");
            int choose;
            string type;
            choose = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (choose)
            {
                case 1:
                    {
                        type = "Квадрат";
                        Shape shape = ShapeFactory.GetShape(type);
                        Console.WriteLine(shape.Calculate());
                    }
                    break;
                case 2:
                    {
                        type = "Прямоугольник";
                        Shape shape = ShapeFactory.GetShape(type);
                        Console.WriteLine(shape.Calculate());
                    }
                    break;
                case 3:
                    {
                        type = "Круг";
                        Shape shape = ShapeFactory.GetShape(type);
                        Console.WriteLine(shape.Calculate());
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
