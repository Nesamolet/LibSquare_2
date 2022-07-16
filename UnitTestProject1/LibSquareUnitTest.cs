using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nCircle;
using nTriangle;


namespace UnitTest
{
    [TestClass]
    public class LibSquareUnitTest
    {
        [TestMethod]
        public void CircleInputValidation()
        {
           

                NUnit.Framework.Assert.Throws<Exception>(() => new Circle(-3));
                NUnit.Framework.Assert.Throws<Exception>(() => new Circle(0));


            
            


        }

        [TestMethod]
        public void CircleGetArea()
        {

            int r = 3;
            Circle circle = new Circle(r);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(Math.PI * r * r, circle.GetArea());
        }


        [TestMethod]
        public void TriangleInputValidation()
        {
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(-3, 4, 5));
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(3, -4, 5));
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(3, 4, -5));
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(0, 4, 5));
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(3, 0, 5));
            NUnit.Framework.Assert.Throws<Exception>(() => new Triangle(3, 4, 0));
        }

        [TestMethod]
        public void TriangleGetArea()
        {

     
            Triangle triangle = new Triangle(3, 4, 5);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(6, triangle.GetArea());

        }


    }
}
