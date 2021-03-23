using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Array = HomeworkMethods.Array;

namespace HomeworkMethodsTest
{
    public class ArrayTest
    {
        [TestCase(new int[] {-99, 0, -9999, 12, 3749}, -9999)]

        public void FindMin(int[] array, int expected)
        {
            var actual = Array.FindMin(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {0, 23, 13, 32, 2, 99}, 99)]

        public void FindMax(int[] array, int expected)
        {
            var actual = Array.FindMax(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -99, 0, -9999, 12, 3749 }, 2)]

        public void FindMinIndex(int[] array, int expected)
        {
            var actual = Array.FindMinIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 23, 13, 32, 2, 99 }, 5)]

        public void FindMaxIndex(int[] array, int expected)
        {
            var actual = Array.FindMaxIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {23, 21, 1, 1, 9, -22}, 0)]

        public void SumOfNumWithOddIndex(int[] array, int expected)
        {
            var actual = Array.SumOfNumWithOddIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3}, new int[] {3,2,1})]
        [TestCase(new int[] { 100, 2, 2}, new int[] {2,2,100})]

        public void ReverseArray(int[] array, int[] expected)
        {
            var actual = Array.ReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3,4,5,6}, 3)]
        [TestCase(new int[] {-1,-2,-3,-4,-5,-6}, 3)]
        [TestCase(new int[] {0,0,0,0,0,0}, 0)]

        public void CountOddElements(int[] array, int expected)
        {
            var actual = Array.CountOddElements(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {2, 3, 1, 2}, new int[] {1, 2, 2, 3})]
        [TestCase(new int[] {2, 3, 1, 2, 6}, new int[] {2, 6, 1, 2, 3})]

        public void ReversHalf(int[] array, int[] expected)
        {
            var actual = Array.ReversHalf(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{23, 54, 2, 37, 342, 3}, new int[]{2, 3, 23, 37, 54, 342})]
        [TestCase(new int[]{324,5,6,545,12,76,89,12,89}, new int[] {5,6,12,12,76,89,89,324,545})]
        
        public void SortInc(int[] array, int[] expected)
        {
            var actual = Array.SortInc(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{3,6,3,5,9,4,9,0}, new int[]{9,9,6,5,4,3,3,0})]
        [TestCase(new int[]{45,87,2,0,34,7,1}, new int[]{87,45,34,7,2,1,0})]
        
        public void SortDec(int[] array, int[] expected)
        {
            var actual = Array.SortDec(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(2, -99)]
        public void FindMin(int testCase, int expected)
        {
            var actual = Array.FindMin(GetArrayForTest(testCase));

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 76)]
        [TestCase(2,9)]

        public void FindMax(int testCase, int expected)
        {
            var actual = Array.FindMax(GetArrayForTest(testCase));

            Assert.AreEqual(expected,actual);
        }

        [TestCase(1, new int[]{1,4})]
        [TestCase(2, new int[]{0,5})]

        public void FindMinIndex(int testCase, int[] expected)
        {
            var actual = Array.FindMinIndex(GetArrayForTest(testCase));

            Assert.AreEqual(expected,actual);
        }

        [TestCase(1, new int[]{1,1})]
        [TestCase(2, new int[]{0,4})]

        public void FindMaxIndex(int testCase, int[] expected)
        {
            var actual = Array.FindMaxIndex(GetArrayForTest(testCase));

            Assert.AreEqual(expected,actual);
        }
        
        [TestCase(1, 2)]
        [TestCase(2, 2)]

        public void CountBiggestNeighbour(int testCase, int expected)
        {
            var actual = Array.CountBiggestNeighbour(GetArrayForTest(testCase));

            Assert.AreEqual(expected,actual);
        }

        private int[,] GetArrayForTest(int testCase)
        {
            switch (testCase)
            {
                case 1:
                    return new int[,] {{4, 34, 65, 67,5}, {3, 76, 32, 1, 0}};

                case 2:
                    return new int[,] {{3, 7, 4, 1, 9, -99}, {-4, -3, -45, -54, -00, -65}};
            }

            return new int[,] {};
        }
    }
}
