using GeometicFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometicFigures
{
    public class Circle : Figure
    {
        // Расчет площади круга по радиусу
        public Circle(double r)
        {
            Square = r * 3.14;
        }

    }
}
