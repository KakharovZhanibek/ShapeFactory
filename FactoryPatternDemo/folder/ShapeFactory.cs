using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.folder
{
    class ShapeFactory
    {
        public static ShapeFactory sf;

        private ShapeFactory()
        {

        }
        public ShapeFactory GetFactory()
        {
            if (sf == null)
            {
                return new ShapeFactory();
            }
            else
            {
                return sf;
            }
        }
        public static Shape GetShape(string type)
        {
            Shape s = null;
            switch (type)
            {
                case "Квадрат":
                    {
                        int a;
                        Console.WriteLine("Введите сторону квадрата");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        s = new Square(a);
                    }
                    break;
                case "Прямоугольник":
                    {
                        int a, b;
                        Console.WriteLine("Введите стороны прямоугольника");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        s = new Rectangle(a, b);
                    }
                    break;
                case "Круг":
                    {
                        int radius;
                        Console.WriteLine("Введите радиус круга");
                        radius = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        s = new Circle(radius);
                    }
                    break;
                    
            }
            return s;
        }
    }
}
