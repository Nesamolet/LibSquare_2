using AFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTriangle
{
    public class Triangle : Figure
    {

        double a, b, c;

        public Triangle(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;

            InputValidation();

        }

        public override void InputValidation()
        {

            if ((a <= 0) || (b <= 0) || (c <= 0)) throw new Exception("Ни одна из сторон треугольника не может быть меньше или равна нуля!");
        }

        public override double GetArea()
        {

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return a * b / 2;

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));


        }
    }
}
