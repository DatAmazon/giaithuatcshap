using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEasyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1Test();
            Exercise2Test();
            Exercise3Test();
            Exercise4Test();
            Exercise5Test();
            Exercise6Test();
            Exercise7Test();
            Exercise8Test();
            Exercise9Test();
            Exercise11Test();
            Exercise10Test();
            Exercise12Test();
            Exercise13Test();
            Exercise14Test();
            Exercise15Test();
            Console.WriteLine("khong co loi gi");
        }
        //Swap the values of 3 numbers a, b and c
        static float[] Exercise1(float a, float b, float c)
        {
            float d;
            d = c;
            c = b;
            b = a;
            a = d;
            float[] result = new float[] { a, b, c };
            return result;
        }
        static void Exercise1Test()
        {
            object[] testData1 = new object[] { 3f, 4f, 5f, 5f, 3f, 4f, "Test case easy 01 - 01 - doi cho 3 so duong" };
            object[] testData2 = new object[] { 1.2f, -3.4f, 5.6f, 5.6f, 1.2f, -3.4f, "Test case easy 01 - 02 - doi cho 3 so thap phan" };
            object[] testData3 = new object[] { -5f, -7f, -9f, -9f, -5f, -7f, "Test case easy 01 - 03 - doi cho 3 so am" };
            object[] testData4 = new object[] { 3f, -14.6f, 5.4f, 5.4f, 3f, -14.6f, "Test case easy 01 - 03 - doi cho 3 so am, duong, thap phan" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise1((float)testDataItem[0], (float)testDataItem[1], (float)testDataItem[2]), new float[] { (float)testDataItem[3], (float)testDataItem[4], (float)testDataItem[5] }), (string)testDataItem[6]);
            }

        }
        //Calculate a to the power of b
        static double Exercise2(int a, int b)
        {
            int c = 1;
            if (b == 0)
            {
                return 1;
            }
            else if (b == 1)
            {
                return a;
            }
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    c = c * a;
                }
                return c;
            }
        }
        static void Exercise2Test()
        {
            object[] testData1 = new object[4] { 2, 5, 32f, "Test case easy 02 - 01 - mu hai so duong" };
            object[] testData2 = new object[4] { 5, 0, 1f, "Test case easy 02 - 02 - mu 0" };
            object[] testData3 = new object[4] { 0, 4, 0f, "Test case easy 02 - 03 - 0 mu" };
            object[] testData4 = new object[4] { 3, -2, 1 / 9f, "Test case easy 02 - 04 - mu am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise2((int)testDataItem[0], (int)testDataItem[1]) == (float)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Check the parity uniformity of 2 numbers
        static string Exercise3(int a, int b)
        {
            int c = a + b;
            string res = "";
            if (c % 2 == 0)//2 so cung le or 2 so cung chan
            {
                if (a % 2 == 0)
                {
                    res += "cung chan";
                }
                else
                {
                    res += "cung le";
                }
                //res += (a % 2 == 0) ? "cung chan" : "cung le";
            }
            else
            {
                res += "mot chan, mot le";
            }
            return res;
        }
        static void Exercise3Test()
        {
            object[] testData1 = new object[4] { 2, 78, "cung chan", "Test case easy 03 - 01 - 2 so nguyen duong chan" };
            object[] testData2 = new object[4] { 9, 83, "cung le", "Test case easy 03 - 02 - 2 so nguyen duong le" };
            object[] testData3 = new object[4] { 2, -31, "mot chan, mot le", "Test case easy 03 - 03 - 2 so nguyen le am va duong" };
            object[] testData4 = new object[4] { -7, -31, "cung le", "Test case easy 03 - 04 - 2 so nguyen am le" };
            object[] testData5 = new object[4] { -4, -32, "cung chan", "Test case easy 03 - 05 - 2 so nguyen am chan" };

            object[][] testData = new object[5][] { testData1, testData2, testData3, testData4, testData5 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise3((int)testDataItem[0], (int)testDataItem[1]) == (string)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Counts the number of even numbers in an array
        static int Exercise4(int[] arr)
        {
            int eventNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    eventNumber++;
                }
            }
            return eventNumber;
        }
        static void Exercise4Test()
        {
            object[] testData1 = new object[] { new int[] { 1, 2, 3, 4, 5, 0, 6 }, 4, "Test case easy 04 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new int[] { 2, 4, -6, 8, -5 }, 4, "Test case easy 04 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new int[] { -1, -3, 0, -5, -7 }, 1, "Test case easy 04 - 03 - mang so nguyen duong am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise4((int[])testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Counts the number of odd numbers in an array
        static int Exercise5(int[] arr)
        {
            int oddNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddNumber++;
                }
            }
            return oddNumber;
        }
        static void Exercise5Test()
        {
            object[] testData1 = new object[] { new int[] { 1, 2, 3, 4, 5, 0, 6 }, 3, "Test case easy 05 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new int[] { 2, 4, -6, 8, -5 }, 1, "Test case easy 05 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new int[] { -1, -3, 0, -5, -7 }, 4, "Test case easy 05 - 03 - mang so nguyen am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise5((int[])testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        // Sum the even numbers in the array
        static int Exercise6(int[] arr)
        {
            int eventNumber = 0;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    eventNumber++;
                    total += arr[i];
                }
            }
            return total;
        }
        static void Exercise6Test()
        {
            object[] testData1 = new object[] { new int[] { 1, 2, 3, 4, 5, 0, 6 }, 12, "Test case easy 06 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new int[] { 2, 4, -6, 8, -5 }, 8, "Test case easy 06 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new int[] { -1, -3, 0, -5, -7 }, 0, "Test case easy 06 - 03 - mang so nguyen duong am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise6((int[])testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);

            }
        }
        // Sum the odd numbers in the array
        static int Exercise7(int[] arr)
        {
            int eventNumber = 0;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    eventNumber++;
                    total += arr[i];
                }
            }
            return total;
        }
        static void Exercise7Test()
        {
            object[] testData1 = new object[] { new int[] { 1, 2, 3, 4, 5, 0, 6 }, 9, "Test case easy 07 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new int[] { 2, 4, -6, 8, -5 }, -5, "Test case easy 07 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new int[] { -1, -3, 0, -5, -7 }, -16, "Test case easy 07 - 03 - mang so nguyen duong am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise7((int[])testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Check primes
        static bool Exercise8(int a)
        {
            bool check = true;
            if (a < 2)
            {
                return check = false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return check = false;
                }
            }

            return check;
        }
        static void Exercise8Test()
        {
            object[] testData1 = new object[] { 0, false, "Test case easy 08 - 01 - so 0" };
            object[] testData2 = new object[] { 1, false, "Test case easy 08 - 02 - so 1" };
            object[] testData3 = new object[] { -17, false, "Test case easy 08 - 03 - so am" };
            object[] testData4 = new object[] { 101, true, "Test case easy 08 - 04 - so nguyen to" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise8((int)testDataItem[0]) == (bool)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Remainder of a divided by b
        static int Exercise9(int a, int b)
        {
            int t = a;
            if (b == 0)
            {
                throw new DivideByZeroException("b khong duoc bang 0");
            }
            else if (a >= 0 && b > 0)
            {
                while (a >= b)
                {
                    a = a - b;
                }
            }
            else if (a <= 0 && b < 0)
            {
                while (a <= b)
                {
                    a = a - b;
                }
                return a * -1;
            }
            else if (a <= 0 && b > 0)
            {
                a = a * -1;
                while (a >= b)
                {
                    a = a - b;
                }
                return a * -1;
            }
            else if (a >= 0 && b < 0)
            {
                b = b * -1;
                while (a >= b)
                {
                    a = a - b;
                }
            }
            return a;
        }
        static void Exercise9Test()
        {
            object[] testData1 = new object[] { 7, 4, 3, "Test case easy 09 - 01 - so duong chia so duong" };
            object[] testData2 = new object[] { -17, 5, -2, "Test case easy 09 - 02 - so am chia so duong" };
            object[] testData3 = new object[] { 17, -5, 2, "Test case easy 09 - 03 - so duong chia am" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise9((int)testDataItem[0], (int)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Find the largest value in an array of numbers
        static float Exercise10(float[] arr)
        {
            //int[] arr = new int[] { -1, 2, 3, -4, 175, 0, 6 };
            float Max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }
        static void Exercise10Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, -3f, 4f, -5f, 0f, 6f }, 6f, "Test case easy 10 - 01 - mang so nguyen" };
            object[] testData2 = new object[] { new float[] { 1f, 2f, -3.345f, 4f, -5f, 0f, 9.345f }, 9.345f, "Test case easy 10 - 01 - mang so thap phan" };


            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise10((float[])testDataItem[0]) == (float)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Find the largest value in an array of numbers
        static float Exercise11(float[] arr)
        {
            //int[] arr = new int[] { -1, 2, 3, -4, 175, 0, 6 };
            float Min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            return Min;
        }
        static void Exercise11Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, -3f, 4f, -5f, 0f, 6f }, -5f, "Test case easy 11 - 01 - mang so nguyen" };
            object[] testData2 = new object[] { new float[] { 1f, 2f, -3.345f, 4f, -5f, 0f, 9.345f }, -5f, "Test case easy 11 - 01 - mang so thap phan" };


            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise11((float[])testDataItem[0]) == (float)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Find the mean of an array of numbers
        static double Exercise12(float[] arr)
        {
            float sum = 0;
            int length = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / length;
        }
        static void Exercise12Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 6f, -3f, 4f, -5f, 0f, 18f }, 3f, "Test case easy 12 - 01 - mang so nguyen" };
            object[] testData2 = new object[] { new float[] { 16f, 4f, 4f, -3.5f, 3f, 5f, 0f, -4.5f }, 3f, "Test case easy 12 - 01 - mang so thap phan" };


            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise12((float[])testDataItem[0]) == (float)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Reverse order of numbers in array
        static float[] Exercise13(float[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                float temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }
            return arr;
        }
        static void Exercise13Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 3f, 2f, 1f }, "Test case easy 13 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { -5f, 8f, -6f, 4f, 2f }, "Test case easy 13 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 0f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -0f, -3.65f, -1.76f }, "Test case easy 13 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise13((float[])testDataItem[0]), (float[])testDataItem[1]), (string)testDataItem[2]);
            }
        }
        //Find the position of a number in an array of numbers
        static int Exercise14(float[] b, float a)
        {
            //int[] b = new int[] { -4, 3, 0, 6, 15 };
            int position = -1;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == a)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
        static void Exercise14Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, 3f, 2, "Test case easy 14 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, 8f, 3, "Test case easy 14 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 0f, -5.78f, -7.9f }, -7.9f, 4, "Test case easy 14 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise14((float[])testDataItem[0], (float)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Exercise15 function
        static int Exercise15(int n)
        {
            int result = 1;
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return result;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

        }
        static void Exercise15Test()
        {
            object[] testData1 = new object[] { 4, 24, "Test case easy 15 - 01 - so nguyen duong" };
            object[] testData2 = new object[] { 1, 1, "Test case easy 15 - 02 - so 1" };
            object[] testData3 = new object[] { 0, 1, "Test case easy 15 - 03 - so 1" };
            object[] testData4 = new object[] { -45, -1, "Test case easy 15 - 04 - mang so nguyen duong" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise15((int)testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
    }
}
