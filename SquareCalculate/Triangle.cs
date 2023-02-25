using GeometicFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometicFigures
{
    public class Triangle : Figure
    {

        private readonly bool Right;

        public bool IsRight()
        {
            return Right;
        }

        public Triangle(int a, int b, int c)
        {
            if(isTriangle(a, b, c))
            {
                isRight(a, b, c);
                Square = SquareCalc(a, b, c);
            }
        }

        double SquareCalc(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 6);
        }

        bool isTriangle(int a, int b, int c)
        {
            if(a==0 | b==0 | c == 0)
            {
                throw new ArgumentException("Invalid argument");
            }
            else if (a+b>c & a+c>b & b+c>a)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Not triangle");
            }
        }

        bool isRight(int a, int b, int c)
        {
            double[] sort = new double[3] { a, b, c };
            if (b > a)
            {
                sort[0] = b;
            }
            if (c > sort[0])
            {
                sort[0] = c;
            }

            if (Math.Pow(sort[0], 2) == Math.Pow(sort[1], 2) + Math.Pow(sort[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
