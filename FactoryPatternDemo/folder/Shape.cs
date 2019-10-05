using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo.folder
{
    interface Shape
    {
        void Draw();
        double Calculate();
        double CalculateScale();
    }
}
