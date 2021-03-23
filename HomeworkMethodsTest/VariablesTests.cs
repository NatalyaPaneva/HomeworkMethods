using System;
using System.Collections.Generic;
using System.Text;
using HomeworkMethods;
using NUnit.Framework;

namespace HomeworkMethodsTest
{
    public class VariablesTests
    {
        [TestCase(5, 6, 61)]
        [TestCase(2, 3, 19)]

        public void SolveEquation(double a, double b, double expected)
        {
            var actual = Variables.SolveEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(23,45)]
        [TestCase(345, 67)]
        [TestCase(234,4)]

        public void Swap(int a, int b)
        {
            var expectedA = b;
            var expectedB = a;
            Variables.Swap(ref a, ref b);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB,b);
        }

        [TestCase(24,6, new int[]{4, 0})]
        [TestCase(35, 5 , new int[]{7, 0})]
        [TestCase(50, 3,new int[]{16, 2})]

        public void Divide(int a, int b, int[] expected)
        {
            var actual = Variables.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(23,3,5,0.09)]
        [TestCase(30,0,5, 0.17)]
        [TestCase(4,8,56, 12)]
        public void SolveLinearEquation(double a, double b, double c, double expected)
        {
            var actual = Variables.SolveLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,3,2,1, new double[]{-1,4})]
        [TestCase(23,42,12,1, new double[]{-0.58, 25.36})]

        public void DeriveEquation(double x1, double x2, double y1, double y2, double[] expected)
        {
            var actual = Variables.DeriveEquation(x1, x2, y1, y2);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(0,0)]
        [TestCase(5,5)]
        public void SolveEquation_WhenDividerEqualTo0_ShouldException(int a, int b)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Variables.SolveEquation(a, b));

            Assert.That(ex.Message, Is.EqualTo("Divided by zero"));
        }

        [TestCase(1, 0)]
        [TestCase(6, 0)]
        public void Divide_WhenDividerEqualTo0_ShouldException(int a, int b)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Variables.Divide(a, b));

            Assert.That(ex.Message, Is.EqualTo("Divide by zero"));
        }

        [TestCase(0, 0, 3)]
        [TestCase(0, 0, 0)]
        public void SolveLinearEquation_WhenDividerEqualTo0_ShouldException(int a, int b, int c)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Variables.SolveLinearEquation(a, b, c));

            Assert.That(ex.Message, Is.EqualTo("Divide by zero"));
        }

        [TestCase(5, 5, 2, 3)]
        [TestCase(10, 10, 2, 3)]
        public void DeriveEquation_WhenDividerEqualTo0_ShouldException(double x1, double x2, double y1, double y2)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Variables.DeriveEquation(x1, x2, y1, y2));

            Assert.That(ex.Message, Is.EqualTo("Divide by zero"));
        }
    }
}
