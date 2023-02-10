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

        [Test]
        public void Test7_Triangle_Scalene()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(14, 15, 16);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test8_Triangle_Scalene()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(3, 5, 7);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test9_Triangle_Scalene()
        {
            Triangle t1 = new Triangle();
            String expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            string actual = t1.AnalyzeTriangle(4, 10, 12);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10_ZeroLength()
        {
            Triangle t1 = new Triangle();
            String expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = t1.AnalyzeTriangle(3, 0, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test11_ZeroLength()
        {
            Triangle t1 = new Triangle();
            String expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = t1.AnalyzeTriangle(0, 5, 0);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test12_ZeroLength()
        {
            Triangle t1 = new Triangle();
            String expected = "At least one side of your triangle has a zero length and is thus invalid";
            string actual = t1.AnalyzeTriangle(0, 0, 7);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test13_Triangle_Invalid()
        {
            Triangle t1 = new Triangle();
            string expected = "Based on the values entered, the triangle is INVALID";
            String actual = t1.AnalyzeTriangle(4, 3, 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test14_Triangle_Invalid()
        {
            Triangle t1 = new Triangle();
            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = t1.AnalyzeTriangle(5, 3, 12);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test15_Triangle_Invalid()
        {
            Triangle t1 = new Triangle();
            string expected = "Based on the values entered, the triangle is INVALID";
            string actual = t1.AnalyzeTriangle(6, 6, 15);
            Assert.AreEqual(expected, actual);
        }





    }
}
