using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.folder
{
    class Circle : Shape
    {
        public int radius { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Calculate()
        {
            Console.WriteLine("Вычислить: \n1.Площадь\n2.Длину\n3.Диаметр");
            double result = 0;
            int choose;
            choose = Int32.Parse(Console.ReadLine().ToString());
            Console.Clear();
            switch (choose)
            {
                case 1:
                    {
                        result = CalculateScale();
                    }
                    break;
                case 2:
                    {
                        result = 2 * Math.PI * radius;
                    }
                    break;
                case 3:
                    {
                        result = 2 * radius;
                    }
                    break;
            }
            return result;
        }

        public void Draw()
        {

        }

        public double CalculateScale()
        {
            return Math.Pow(Math.PI * this.radius, 2);
        }
    }
}
