using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHardCSharp
{
    class ExHardProgram
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
            Exercise10Test();
            Exercise11Test();
            Exercise12Test();
            Console.WriteLine("khong co loi gi");
        }
        // Function that reverses the character of each word in a sentence
        static string Exercise1(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            // Reverse characters in string
            {
                newStr += str[i];
            }
            string[] strSplit = newStr.Split(' ');// Cut string by character ' '
            string strFinish = "";
            for (int i = strSplit.Length - 1; i >= 0; i--)
            {
                strFinish += i > 0 ? strSplit[i] + " " : strSplit[i];
            }
            return (strFinish);
        }
        static void Exercise1Test()
        {
            object[] testData1 = new object[] { "It should only a contain three elements", "tI dluohs ylno a niatnoc eerht stnemele", "Test case hard 01 - 01 - chuoi binh thuong" };
            object[] testData2 = new object[] { "", "", "Test case hard 01 - 02 - chuoi rong" };

            object[][] testData = new object[1][] { testData1 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise1((string)testDataItem[0]) == (string)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Random between a and b
        static bool Exercise2(int a, int b)
        {
            Random random = new Random();
            double randomValue = random.NextDouble();
            double result = a + (randomValue * (b - a));
            return (a < b && result <= b && result >= a);
        }
        static void Exercise2Test()
        {
            object[] testData1 = new object[] { 3, 8, true, "Test case hard 02 - 01 - a < b" };
            object[] testData2 = new object[] { 6, 4, false, "Test case hard 02 - 02 - a > b" };
            object[] testData3 = new object[] { 0, 0, false, "Test case hard 02 - 03 - a = b = 0" };

            object[][] testData = new object[1][] { testData1 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise2((int)testDataItem[0], (int)testDataItem[1]) == (bool)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Join 2 sorted arrays of numbers in ascending order
        static float[] Exercise3(float[] arr1, float[] arr2)
        {
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            float[] newArr = new float[lengthTotal];

            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] > newArr[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }
            return newArr;
        }
        static void Exercise3Test()
        {
            object[] testData2 = new object[] { new float[] { 14f, -20f, -12f, 32f }, new float[] { 7f, -5f }, new float[] { -20f, -12f, -5f, 7f, 14f, 32f }, "Test case hard 03 - 01 - mang so nguyen duong va am" };
            object[] testData1 = new object[] { new float[] { -3.5f, -6.25f }, new float[] { 2.5f, -2.5f }, new float[] { -6.25f, -3.5f, -2.5f, 2.5f }, "Test case hard 03 - 02 - mang so thap phan" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise3((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Join 2 sorted arrays of numbers in descending order
        static float[] Exercise4(float[] arr1, float[] arr2)
        {
            //Console.WriteLine("Noi 2 mang va sap xep theo theo chieu giam dan");
            //int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            //int[] arr2 = new int[] { 6, 15, -45, 3, 7, 34, 31, 6 };
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            float[] newArr = new float[lengthTotal];


            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] < newArr[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }
            return newArr;
        }
        static void Exercise4Test()
        {
            object[] testData2 = new object[] { new float[] { 14f, -20f, -12f, 32f }, new float[] { 7f, -5f }, new float[] { 32f, 14f, 7f, -5f, -12f, -20f }, "Test case hard 04 - 01 - mang so nguyen duong va am" };
            object[] testData1 = new object[] { new float[] { -3.5f, -6.25f }, new float[] { 2.5f, -2.5f }, new float[] { 2.5f, -2.5f, -3.5f, -6.25f }, "Test case hard 04 - 02 - mang so thap phan" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise4((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Join 2 sorted arrays of numbers in ascending order
        static float[] Exercise5(float[] arr1, float[] arr2)
        {
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            float[] newArr = new float[lengthTotal];

            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] > newArr[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }
            return newArr;
        }
        static void Exercise5Test()
        {
            object[] testData2 = new object[] { new float[] { 14f, -20f, -12f, 32f }, new float[] { 7f, -5f }, new float[] { -20f, -12f, -5f, 7f, 14f, 32f }, "Test case hard 03 - 01 - mang so nguyen duong va am" };
            object[] testData1 = new object[] { new float[] { -3.5f, -6.25f }, new float[] { 2.5f, -2.5f }, new float[] { -6.25f, -3.5f, -2.5f, 2.5f }, "Test case hard 03 - 02 - mang so thap phan" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise5((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Join 2 sorted arrays of numbers in descending order
        static float[] Exercise6(float[] arr1, float[] arr2)
        {
            //Console.WriteLine("Noi 2 mang va sap xep theo theo chieu giam dan");
            //int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            //int[] arr2 = new int[] { 6, 15, -45, 3, 7, 34, 31, 6 };
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            float[] newArr = new float[lengthTotal];


            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[i + arr1.Length] = arr2[i];
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[i] < newArr[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }
            return newArr;
        }
        static void Exercise6Test()
        {
            object[] testData2 = new object[] { new float[] { 14f, -20f, -12f, 32f }, new float[] { 7f, -5f }, new float[] { 32f, 14f, 7f, -5f, -12f, -20f }, "Test case hard 04 - 01 - mang so nguyen duong va am" };
            object[] testData1 = new object[] { new float[] { -3.5f, -6.25f }, new float[] { 2.5f, -2.5f }, new float[] { 2.5f, -2.5f, -3.5f, -6.25f }, "Test case hard 04 - 02 - mang so thap phan" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise6((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //The word a number describes the number in an amount in words
        static string Exercise7(float amount)
        {
            string words = "";
            //string[] ones =
            //{
            //    "dong",
            //    "mot",
            //    "hai",
            //    "ba",
            //    "bon",
            //    "nam",
            //    "sau",
            //    "bay",
            //    "tam",
            //    "chin",
            //    "muoi",
            //    "muoi mot",
            //    "muoi hai",
            //    "muoi ba",
            //    "muoi bon",
            //    "muoi lam",
            //    "muoi sau",
            //    "muoi bay",
            //    "muoi tam",
            //    "muoi chin"
            //};

            if (amount == 0)
            {
                return "khong dong";
            }
            if (amount < 0)
            {
                words += "am ";
                amount = -amount;
            }

            int intPart = (int)amount;
            if (intPart > 0)
            {
                words += ConvertNumberToWords(intPart) + " " + "dong";
            }

            int decimalPart = (int)Math.Round((amount - intPart) * 100);
            if (decimalPart > 0)
            {
                words += " " + ConvertNumberToWords(decimalPart) + " " + "xu";
            }

            return words;
        }
        public static string ConvertNumberToWords(int number)
        {
            string[] ones = new string[]
                {
                    "dong",
                    "mot",
                    "hai",
                    "ba",
                    "bon",
                    "nam",
                    "sau",
                    "bay",
                    "tam",
                    "chin",
                    "muoi",
                    "muoi mot",
                    "muoi hai",
                    "muoi ba",
                    "muoi bon",
                    "muoi lam",
                    "muoi sau",
                    "muoi bay",
                    "muoi tam",
                    "muoi chin"
                };
            string[] tens = new string[]
                {
                    "",
                    "",
                    "hai muoi",
                    "ba muoi",
                    "bon muoi",
                    "nam muoi",
                    "sau muoi",
                    "bay muoi",
                    "tam muoi",
                    "chin muoi"
                };
            if (number < 20)
            {
                return ones[number];
            }
            if (number < 100)
            {
                return tens[number / 10] + ((number % 10 > 0) ? " " + ones[number % 10] : "");
            }
            if (number < 1000)
            {
                return ones[number / 100] + " tram" + ((number % 100 > 0) ? " " + ConvertNumberToWords(number % 100) : "");
            }
            if (number < 1000000)
            {
                return ConvertNumberToWords(number / 1000) + " nghin" + ((number % 1000 > 0) ? " " + ConvertNumberToWords(number % 1000) : "");
            }
            if (number < 1000000000)
            {
                return ConvertNumberToWords(number / 1000000) + " trieu" + ((number % 1000000 > 0) ? " " + ConvertNumberToWords(number % 1000000) : "");
            }

            return ConvertNumberToWords(number / 1000000000) + " ty" + ((number % 1000000000 > 0) ? " " + ConvertNumberToWords(number % 1000000000) : "");
        }
        static void Exercise7Test()
        {
            object[] testData1 = new object[] { 0f, "khong dong", "Test case easy 07 - 01 - tien bang 0" };
            object[] testData2 = new object[] { 452000f, "bon tram nam muoi hai nghin dong", "Test case easy 07 - 01 - tien chan" };
            object[] testData3 = new object[] { 5555f, "nam nghin nam tram nam muoi nam dong", "Test case easy 07 - 01 - tien le" };
            object[] testData4 = new object[] { -5555f, "am nam nghin nam tram nam muoi nam dong", "Test case easy 07 - 01 - tien am" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise7((float)testDataItem[0]) == (string)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Calculate the minimum amount of currency to convert
        static string Exercise8(int total)
        {
            if (total < 0)
            {
                return "-1";
            }
            int m500 = 0, m200 = 0, m100 = 0, m50 = 0, m20 = 0, m10 = 0, m5 = 0, m2 = 0, m1 = 0;//m stands for money
            m500 = (total - (total % 500000)) / 500000;
            total = total - (m500 * 500000);
            m200 = (total - (total % 200000)) / 200000;
            total = total - (m200 * 200000);
            m100 = (total - (total % 100000)) / 100000;
            total = total - (m100 * 100000);
            m50 = (total - (total % 50000)) / 50000;
            total = total - (m50 * 50000);
            m20 = (total - (total % 20000)) / 20000;
            total = total - (m20 * 20000);
            m10 = (total - (total % 10000)) / 10000;
            total = total - (m10 * 10000);
            m5 = (total - (total % 5000)) / 5000;
            total = total - (m5 * 5000);
            m2 = (total - (total % 2000)) / 2000;
            total = total - (m2 * 2000);
            m1 = (total - (total % 1000)) / 1000;
            total = total - (m5 * 1000);

            return ("The amount of 500000 is: " + m500 + " ; 200000 is: " + m200 + " ; 100000 is: " + m100 + " ; 50000 is: " + m50
              + " ; 20000 is: " + m20 + " ; 10000 is: " + m10 + " ; 5000 is: " + m5 + " ; 2000 is: " + m2 + " ; 1000 is: " + m1);
        }
        static void Exercise8Test()
        {
            object[] testData1 = new object[] { 478500, "The amount of 500000 is: 0 ; 200000 is: 2 ; 100000 is: 0 ; 50000 is: 1 ; 20000 is: 1 ; 10000 is: 0 ; 5000 is: 1 ; 2000 is: 1 ; 1000 is: 1", "Test case easy 08 - 01 - tien nghin chan" };
            object[] testData2 = new object[] { 10800000, "The amount of 500000 is: 21 ; 200000 is: 1 ; 100000 is: 1 ; 50000 is: 0 ; 20000 is: 0 ; 10000 is: 0 ; 5000 is: 0 ; 2000 is: 0 ; 1000 is: 0", "Test case easy 08 - 01 - tien trieu chan" };
            object[] testData3 = new object[] { 1000000000, "The amount of 500000 is: 2000 ; 200000 is: 0 ; 100000 is: 0 ; 50000 is: 0 ; 20000 is: 0 ; 10000 is: 0 ; 5000 is: 0 ; 2000 is: 0 ; 1000 is: 0", "Test case easy 08 - 01 - tien ty chan" };
            object[] testData4 = new object[] { 0, "The amount of 500000 is: 0 ; 200000 is: 0 ; 100000 is: 0 ; 50000 is: 0 ; 20000 is: 0 ; 10000 is: 0 ; 5000 is: 0 ; 2000 is: 0 ; 1000 is: 0", "Test case easy 08 - 01 - tien bang 0" };
            object[] testData5 = new object[] { -40000, "-1", "Test case easy 08 - 01 - tien am" };

            object[][] testData = new object[5][] { testData1, testData2, testData3, testData4, testData5 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise8((int)testDataItem[0]) == (string)testDataItem[1], (string)testDataItem[2]);
            }

        }
        //Calculate the total number of occurrences of a string a in string b
        static int Exercise9(string a, string b)
        {
            int count = 0;
            for (int i = 0; i <= b.Length - a.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i + j] != a[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    count++;
                }
            }
            return count;
        }
        static void Exercise9Test()
        {
            object[] testData1 = new object[] { "value", "the value function returns the value of the session value variable", 3, "Test case hard 09 - 01 - string a co chua trong string b" };
            object[] testData2 = new object[] { "summer", "the value function returns the value of the session value variable", 0, "Test case hard 09 - 02 - string a khong co trong string b" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise9((string)testDataItem[0], (string)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Shuffles the order of elements in an array of numbers
        static float[] Exercise10(float[] arr)
        {
            Random rand = new Random();
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                float temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return arr;
        }
        static void Exercise10Test()
        {
            //object[] testData1 = new object[] { new float[] { 1f, 3f, 2f }, new float[] { 1f, 2f, 3f }, "Test case easy 01 - 01 - mang so nguyen duong" };
            //object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { -6f, -5f, 2f, 4f, 8f }, "Test case easy 02 - 02 - mang so nguyen duong va am" };
            //object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -3.65f, -1.76f, 78f }, "Test case easy 03 - 03 - mang so thap phan" };

            //object[][] testData = new object[3][] { testData1, testData2, testData3 };
            //for (int i = 0; i < testData.Length; i++)
            //{
            //    object[] testDataItem = testData[i];
            //    Debug.Assert(Enumerable.SequenceEqual(Exercise10((float[])testDataItem[0]), (float[])testDataItem[1]), (string)testDataItem[2]);
            //}
        }
        //Returns the last non-zero digit of n factorial
        static int Exercise11(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            string result = factorial.ToString();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] != '0')
                {
                    result = result[i].ToString();
                    break;
                }
            }
            return Int32.Parse(result);
        }
        static void Exercise11Test()
        {
            object[] testData1 = new object[] { 0, 1, "Test case easy 11 - 01 - so 0" };
            object[] testData2 = new object[] { 1, 1, "Test case easy 11 - 02 - so 1" };
            object[] testData3 = new object[] { 5, 2, "Test case easy 11 - 03 - giai thua co tan cung bang 0" };
            object[] testData4 = new object[] { -5, -1, "Test case easy 11 - 04 - so am" };
            object[] testData5 = new object[] { 4, 4, "Test case easy 11 - 05 - so bat ky" };

            object[][] testData = new object[5][] { testData1, testData2, testData3, testData4, testData5 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise11((int)testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Returns the number of zeros that appear in the value of n factorials
        static int Exercise12(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            int factorial = 1;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            string result = factorial.ToString();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                if (result[i] == '0')
                {
                    count++;
                }
            }
            return count;
        }
        static void Exercise12Test()
        {
            object[] testData1 = new object[] { 0, 0, "Test case easy 12 - 01 - so 0" };
            object[] testData2 = new object[] { 1, 0, "Test case easy 12 - 02 - so 1" };
            object[] testData3 = new object[] { 5, 1, "Test case easy 12 - 03 - giai thua co tan cung bang 0" };
            object[] testData4 = new object[] { 5, 1, "Test case easy 12 - 04 - so am" };
            object[] testData5 = new object[] { 10, 2, "Test case easy 12 - 05 - giai thua co tan cung bang 0" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise12((int)testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
    }
}
