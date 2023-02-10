using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleUnitTest
{
    [TestFixture]
     
    public class Triangle1
    {
        [Test]

        public void Test1_Triangle_Equilateral()
        {
            Triangle t1 = new Triangle();
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            string actual = t1.AnalyzeTriangle(7,7,7);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test2_Triangle_Isosceles()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(7,7,8);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3_Triangle_Isosceles()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(4, 9, 9);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test4_Triangle_Isosceles()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            String actual = t1.AnalyzeTriangle(5, 7, 5);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test5_Triangle_Scalene()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(7, 8, 9);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test6_Triangle_Scalene()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(11, 12, 13);
            Assert.AreEqual(expected, actual);
        }




    }
}
