using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.folder
{
    class Rectangle : Shape
    {
        public int a { get; set; }
        public int b { get; set; }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            Console.WriteLine("Вычислить: \n1.Площадь\n2.Периметр");
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
                        result = 2 * (a + b);
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
            return a * b;
        }
    }
}
