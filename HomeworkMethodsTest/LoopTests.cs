using System;
using System.Collections.Generic;
using System.Text;
using HomeworkMethods;
using NUnit.Framework;

namespace HomeworkMethodsTest
{
    class LoopTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(1, 7, 1)]
        [TestCase(23, 2, 529)]
        [TestCase(9, 3, 729)]
        [TestCase(3, 3, 27)]

        public void MyPow(int a, int b, int expected)
        {
            var actual = Loop.MyPow(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[] {100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(300, new int[] {300, 600, 900})]
        [TestCase(233, new int[] {233, 466, 699, 932})]
        
        public void Deviders(int a, int[] expected)
        {
            var actual = Loop.Dividers(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, 4)]
        [TestCase(35, 5)]
        [TestCase(67, 8)]
        
        public void CountSquareLess(int a, int expected)
        {
            var actual = Loop.CountSquareLess(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(46, 23)]
        [TestCase(55, 11)]
        [TestCase(43, 1)]
        
        public void FindBiggestDivider(int a, int expected)
        {
            var actual = Loop.FindBiggestDivider(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(23, 45, 105)]
        [TestCase(54, 66, 119)]
        [TestCase(99, 127, 462)]

        public void SumOfNumbersInRangeDivideWithoutRemainderBySeven(int a, int b, int expected)
        {
            var actual = Loop.SumOfNumbersInRangeDivideWithoutRemainderBySeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7,new int[]{1, 1, 2, 3, 5, 8, 13})]
        [TestCase(5, new int[]{1, 1, 2, 3, 5})]
        [TestCase(9,new int []{1, 1, 2, 3, 5, 8, 13, 21, 34})]

        public void Fib(int a, int[] expected)
        {
            var actual = Loop.Fib(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(23,77, 1)]
        [TestCase(44,88,44)]
        [TestCase(40,98, 2)]
        [TestCase(0,0, 0)]

        public void FindBiggestDivider(int a, int b, int expected)
        {
            var actual = Loop.FindBiggestDivider(a, b);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(125,5)]
        [TestCase(27, 3)]
        [TestCase(343, 7)]
        [TestCase(0, 0)]

        public void FindNumberOfCube(int a, int expected)
        {
            var actual = Loop.FindNumberOfCube(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(22, 0)]
        [TestCase(98, 1)]
        [TestCase(1278, 2)]
        [TestCase(73246897, 4)]
        [TestCase(65432111, 5)]
        
        public void CountOddNum(int a, int expected)
        {
            var actual = Loop.CountOddNum(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(5231,1325)]
        [TestCase(58421,12485)]
        [TestCase(3348, 8433)]
        [TestCase(4567, 7654)]

        public void ReverseNum(int a, int expected)
        {
            var actual = Loop.ReverseNum(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, new int[]{2,4,6,8,12,14,16,18,20})]
        [TestCase(8, new int[]{2,4,6,8})]
        [TestCase(15, new int[]{2,4,6,8,12,14})]

        public void FindInRangeWhereSumOfEvenNumBiggerThanOdd(int a, int[] expected)
        {
            var actual = Loop.FindInRangeWhereSumOfEvenNumBiggerThanOdd(a);

            Assert.AreEqual(expected,actual);
        }

        [TestCase(3456, 2345, true)]
        [TestCase(805757, 35994, true)]
        [TestCase(23,98, false)]
        [TestCase(456,8482, true)]

        public void IsEqualNum(int a, int b, bool expected)
        {
            var actual = Loop.IsEqualNum(a, b);

            Assert.AreEqual(expected,actual);
        }
        
        [TestCase(0)]
        public void Dividers_WhenDividerEqualTo0_ShouldException(int a)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => Loop.Dividers(a));

            Assert.That(ex.Message, Is.EqualTo("Divide by zero"));
        }

        [TestCase(-2)]
        public void FindInRangeWhereSumOfEvenNumBiggerThanOdd_WhenNumberEqualToNegative_ShouldException(int a)
        {
            var ex = Assert.Throws<ArgumentException>(() => Loop.FindInRangeWhereSumOfEvenNumBiggerThanOdd(a));

            Assert.That(ex.Message, Is.EqualTo("Number should be positive"));
        }

        [TestCase(-19)]
        public void FindNumberOfCube_WhenNumberEqualToNegative_ShouldException(int a)
        {
            var ex = Assert.Throws<ArgumentException>(() => Loop.FindNumberOfCube(a));

            Assert.That(ex.Message, Is.EqualTo("Number should be positive"));
        }
    }
}
