using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkMethods
{
    public class Array
    {
        public static int FindMin(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        public static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int FindMinIndex(int[] array)
        {
            int minIndex = 0;
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindMaxIndex(int[] array)
        {
            int max = 0;
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int SumOfNumWithOddIndex(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static int[] ReverseArray(int[] array) 
        {
            int[] newArray = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[array.Length - i - 1] = array[i];
            }

            return newArray;
        }

        public static int CountOddElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ReversHalf(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array.Length % 2 != 0)
                {
                    int temp = array[i];
                    array[i] = array[array.Length / 2 + 1 + i];
                    array[array.Length / 2 + 1 + i] = temp;
                }
                else
                {
                    int temp = array[i];
                    array[i] = array[array.Length / 2 + i];
                    array[array.Length / 2 + i] = temp;
                }
            }

            return array;
        }

        public static int[] SortInc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static int[] SortDec(int[] array)
        {
            int maxIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[maxIndex] < array[j])
                    {
                        maxIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }

            return array;
        }

        public static int FindMin(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        public static int FindMax(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        public static int[] FindMinIndex(int[,] array)
        {
            int min = array[0, 0];
            int[] result = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        public static int[] FindMaxIndex(int[,] array)
        {
            int max = array[0, 0];
            int[] result = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        public static int CountBiggestNeighbour(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1])
                            {
                                count++;
                            }
                        }
                        else if (j == array.GetLength(1) - 1)
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1])
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1] && array[i, j] > array[i, j + 1])
                            {
                                count++;
                            }
                        }
                    }
                    else if (i == array.GetLength(0) - 1)
                    {
                        if (j == 0)
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j + 1])
                            {
                                count++;
                            }
                        }
                        else if (j == array.GetLength(1) - 1)
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1])
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i, j - 1] && array[i, j] > array[i, j + 1])
                            {
                                count++;
                            }
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i + 1, j] && array[i, j] > array[i, j + 1])
                            {
                                count++;
                            }
                        }
                        else if (j == array.GetLength(1) - 1)
                        {
                            if (array[i, j] > array[i - 1, j] && array[i, j] > array[i + 1, j] && array[i, j] > array[i, j - 1])
                            {
                                count++;
                            }
                        }
                        else
                        {
                            if (array[i, j] > array[i + 1, j] && array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i, j + 1] && array[i, j] > array[i, j - 1])
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
