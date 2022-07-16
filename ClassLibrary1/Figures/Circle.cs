using AFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nCircle
{

   
    public class Circle: Figure
    {
        double r; 


        public Circle(double r)
        {
            
            this.r = r;

            InputValidation();
        }

        public override void InputValidation()
        {
            if (r <= 0) throw new Exception("Радиус не может ,быть меньше или равен нулю!");
        }


        public override double GetArea()
        {

            return Math.PI * Math.Pow(r, 2);

        }

    }
    

    }





