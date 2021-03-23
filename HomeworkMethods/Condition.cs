using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMethods
{
    public class Condition
    {
        public static int CountNumbers(int a, int b)
        {
            if (a > b)
                return a + b;
            else if (a == b)
                return a * b;
            else
                return a - b;
        }

        public static int CountQuarter(int x, int y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x > 0 && y < 0)
                return 4;
            else if (x < 0 && y < 0)
                return 3;
            else if (x < 0 && y > 0)
                return 2;
            else
                return 0;
        }

        public static int[] GetInAscendingOrder(int a, int b, int c)
        {
            int[] result = new int[3];

            if (a < b && a < c)
            {
                result[0] = a;
                if (b < c)
                {
                    result[1] = b;
                    result[2] = c;
                }
                else
                {
                    result[1] = c;
                    result[2] = b;
                }
            }
            else if (b < a && b < c)
            {
                result[0] = b;
                if (a < c)
                {
                    result[1] = a;
                    result[2] = c;
                }
                else
                {
                    result[1] = c;
                    result[2] = a;
                }
            }
            else if (c < a && c < b)
            {
                result[0] = c;
                if (a < b)
                {
                    result[1] = a;
                    result[2] = b;
                }
                else
                {
                    result[1] = b;
                    result[2] = a;
                }
            }
            else
            {
                result[0] = a;
                result[1] = b;
                result[2] = c;
            }

            return result;
        }

        public static int[] CountQuadraticEquation(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;
            int x, x1, x2;

            if (d > 0)
            {
                x1 = (-b + (int)Math.Sqrt(d)) / 2 * a;
                x2 = (-b - (int)Math.Sqrt(d)) / 2 * a;
                return new int[] { x1, x2 };
            }
            else if (d == 0)
            {
                x = (-b / 2 * a);
                return new int[] {x};
            }
            else
            {
                return new int[] { };
            }
        }

        public static string ConvertNumberToString(int a)
        {
            string res = "";
            if (a > 9 && a < 20)
            {
                switch (a)
                {
                    case 10:
                        res += "Ten";
                        break;
                    case 11:
                        res += "Eleven";
                        break;
                    case 12:
                        res += "Twelve";
                        break;
                    case 13:
                        res += "Thirteen";
                        break;
                    case 14:
                        res += "Fourteen";
                        break;
                    case 15:
                        res += "Fifteen";
                        break;
                    case 16:
                        res += "Sixteen";
                        break;
                    case 17:
                        res += "Seventeen";
                        break;
                    case 18:
                        res += "Eighteen";
                        break;
                    case 19:
                        res += "Nineteen";
                        break;
                }
            }
            else if (a > 19 && a < 100)
            {
                switch (a / 10)
                {
                    case 2:
                        res += "Twenty";
                        break;
                    case 3:
                        res += "Thirty";
                        break;
                    case 4:
                        res += "Forty";
                        break;
                    case 5:
                        res += "Fifty";
                        break;
                    case 6:
                        res += "Sixty";
                        break;
                    case 7:
                        res += "Seventy";
                        break;
                    case 8:
                        res += "Eighty";
                        break;
                    case 9:
                        res += "Ninety";
                        break;
                }

                switch (a % 10)
                {
                    case 1:
                        res += " one";
                        break;
                    case 2:
                        res += " two";
                        break;
                    case 3:
                        res += " three";
                        break;
                    case 4:
                        res += " four";
                        break;
                    case 5:
                        res += " five";
                        break;
                    case 6:
                        res += " six";
                        break;
                    case 7:
                        res += " seven";
                        break;
                    case 8:
                        res += " eight";
                        break;
                    case 9:
                        res += " nine";
                        break;
                }
            }

            return res;
        }
    }
}
