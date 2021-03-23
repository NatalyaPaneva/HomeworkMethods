using HomeworkMethods;
using NUnit.Framework;

namespace HomeworkMethodsTest
{
    public class Tests
    {
        [TestCase(5,6,-1)]
        [TestCase(0,0,0)]
        [TestCase(100,-200,-100)]
        public void CountNumbersTest(int a, int b, int expected)
        {
            var actual = Condition.CountNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,0,0)]
        [TestCase(1,1,1)]
        [TestCase(-1,1,2)]
        [TestCase(1,-1,4)]
        [TestCase(-1,-1,3)]
        public void CountQuarter(int x, int y, int expected)
        {
            var actual = Condition.CountQuarter(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 1, new int[] {1, 2, 3})]
        [TestCase(-1, 999, -99999, new int[] {-99999, -1, 999})]
        public void GetInAscendingOrder(int a, int b, int c, int[] expected)
        {
            var actual = Condition.GetInAscendingOrder(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 4, new int[] {})]
        [TestCase(-2, 3, -4, new int[] {})]
        [TestCase(0, 0, 0, new int[] { 0 })]
        public void CountQuadraticEquation(int a, int b, int c, int[] expected)
        {
            var actual = Condition.CountQuadraticEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, "Twenty three")]
        [TestCase(11, "Eleven")]
        [TestCase(77, "Seventy seven")]
        public void ConvertNumberToString(int a, string expected)
        {
            var actual = Condition.ConvertNumberToString(a);

            Assert.AreEqual(expected, actual);
        }
    }
}