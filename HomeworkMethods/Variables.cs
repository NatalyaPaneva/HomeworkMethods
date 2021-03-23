using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HomeworkMethods
{
    public class Variables
    {
        public static double SolveEquation(double a, double b)
        {
            if (b - a == 0)
            {
                throw new DivideByZeroException("Divided by zero");
            }
            
            double d = (5 * a + b * b) / (b - a);
            
            return d;
        }

        public static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static int[] Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divide by zero");
            }

            int[] array = new int[2];
            array[0] = a / b;
            array[1] = a % b;

            return array;
        }

        public static double SolveLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Divide by zero");
            }

            double x = (c - b) / a;

            return Convert.ToDouble(decimal.Round(Convert.ToDecimal(x), 2));
        }

        public static double[] DeriveEquation(double x1, double x2, double y1, double y2)
        {
            if (x1 - x2 == 0)
            {
                throw new DivideByZeroException("Divide by zero");
            }
            
            double[] array = new double[2];
            array[0] = Convert.ToDouble(decimal.Round(Convert.ToDecimal((y1 - y2) / (x1 - x2)), 2));
            array[1] = Convert.ToDouble(decimal.Round(Convert.ToDecimal(y2 - array[0] * x2), 2));

            return array;
        }
    }
}
