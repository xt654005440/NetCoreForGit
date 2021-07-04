using System;
using System.Collections.Generic;
using System.Text;

namespace Forest.ProCharp.Generic
{
    public class DelegateFuns
    {
        public void SubDisplay(int n)
        {
            int res = n * 2;
            Console.WriteLine(res.ToString());

        }

        public static double MultiplyByTwo(double value) => value * 2;

        public static double Square(double value) => value * value;

        public static void Sort(int[] intArray, int compareMode)
        {
            if (compareMode < 0)
            {
                compareMode = 0;
            }

            bool swapped = true;

            if (compareMode > 0)
            {
                while (swapped)
                {
                    swapped = false;
                    for (int i = 0; i < intArray.Length - 1; i++)
                    {
                        if (intArray[i] > intArray[i + 1])
                        {
                            int temp = intArray[i];
                            intArray[i] = intArray[i + 1];
                            intArray[i + 1] = temp;
                            swapped = true;
                        }
                    }
                }
            }
            else
            {
                while (swapped)
                {
                    swapped = false;
                    for (int i = 0; i < intArray.Length - 1; i++)
                    {
                        if (intArray[i] < intArray[i + 1])
                        {
                            int temp = intArray[i];
                            intArray[i] = intArray[i + 1];
                            intArray[i + 1] = temp;
                            swapped = true;
                        }
                    }
                }
            }


        }


    }
}
