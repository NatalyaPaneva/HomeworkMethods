using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMethods
{
    public class Loop
    {
        public static int MyPow(int a, int b)
        {
            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int[] Dividers(int a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Divide by zero");
            }

            int[] tmp = new int[1000];
            int count = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    tmp[count] = i;
                    count++;
                }
            }

            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = tmp[i];
            }

            return result;
        }

        public static int CountSquareLess(int a)
        {
            int result = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (i * i < a)
                    result++;
            }

            return result;
        }

        public static int FindBiggestDivider(int a)
        {
            int result = 0;

            for (int i = a / 2; i > 0; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static int SumOfNumbersInRangeDivideWithoutRemainderBySeven(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int[] Fib(int a)
        {
            int[] result = new int[a];
            int fib1 = 1;
            int fib2 = 1;
            for (int i = 0; i < a; i++)
            {
                if (i == 0 || i == 1)
                {
                    result[i] = 1;
                    continue;
                }
                result[i] = fib1 + fib2;
                int temp = fib1;
                fib1 = fib2;
                fib2 += temp;
            }

            return result;
        }

        public static int FindBiggestDivider(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }

        public static int FindNumberOfCube(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Number should be positive");
            }

            int l = 1;
            int r = a;
            int n = 0;

            while (a != Math.Pow(n, 3))
            {
                if (n == (r + l) / 2)
                    break;
                n = (r + l) / 2;
                if (Math.Pow(n, 3) > a)
                    r = n;
                else
                    l = n;
            }

            return n;
        }

        public static int CountOddNum(int a)
        {
            int result = 0;

            while (a != 0)
            {
                int tmp = a % 10;

                if (tmp % 2 != 0)
                    result++;
                a /= 10;
            }
            return result;
        }

        public static int ReverseNum(int a)
        {
            int result = 0;
            while (a != 0)
            {
                result *= 10;
                int tmp = a % 10;
                result += tmp;
                a /= 10;
            }

            return result;
        }

        public static int[] FindInRangeWhereSumOfEvenNumBiggerThanOdd(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Number should be positive");
            }

            int[] result;
            int[] tmpArr = new int[a];
            int count = 0;

            for (int i = 1; i <= a; i++)
            {
                int temp = i;
                int even = 0;
                int odd = 0;
                while (temp != 0)
                {
                    int tmp = temp % 10;
                    if (tmp % 2 == 0)
                        even += tmp;
                    else
                        odd += tmp;
                    temp /= 10;
                }

                if (odd < even)
                {
                    tmpArr[count] = i;
                    count++;
                }
            }

            result = new int[count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = tmpArr[i];
            }

            return result;
        }

        public static bool IsEqualNum(int a, int b)
        {
            bool isEqual = false;
            while (a != 0)
            {
                int b1 = b;
                int temp = a % 10;
                while (b1 != 0)
                {
                    int tmp = b1 % 10;
                    if (temp == tmp)
                    {
                        isEqual = true;
                        break;
                    }

                    b1 /= 10;
                }
                if (isEqual)
                    break;
                a /= 10;
            }

            return isEqual;
        }
    }
}
