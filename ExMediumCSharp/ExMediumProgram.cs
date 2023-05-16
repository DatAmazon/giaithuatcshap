using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMediumCSharp
{
    class ExMediumProgram
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
            Exercise13Test();
            Exercise14Test();
            Exercise15Test();
            Exercise16Test();
            Exercise17Test();
            Exercise18Test();
            Console.WriteLine("khong co loi gi");
        }
        //Sort array ascending
        static float[] Exercise1(float[] arr)
        {
            float num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        num = arr[i];
                        arr[i] = arr[j];
                        arr[j] = num;
                    }
                }
            }
            return arr;
        }
        static void Exercise1Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 3f, 2f }, new float[] { 1f, 2f, 3f }, "Test case medium 01 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { -6f, -5f, 2f, 4f, 8f }, "Test case medium 02 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -3.65f, -1.76f, 78f }, "Test case medium 03 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise1((float[])testDataItem[0]), (float[])testDataItem[1]), (string)testDataItem[2]);
            }
        }
        //Concat array of the same size
        static float[] Exercise2(float[] arr1, float[] arr2)
        {
            int length = arr1.Length + arr2.Length;
            float[] newArr = new float[length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                newArr[arr1.Length + i] = arr2[i];
            }
            return newArr;
        }
        static void Exercise2Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 3f }, new float[] { 1f, 2f, 3f, 1f, 3f, 3f }, "Test case medium 02 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 2f, 4f, -6f, 8f, -5f, 7f, -5f, 2f, 4f, 8f }, "Test case medium 02 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -3.65f, -1.76f, 78f }, new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f, -7.9f, -5.78f, -3.65f, -1.76f, 78f }, "Test case medium 02 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise2((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);

            }
        }
        //Add 2 arrays of the same size
        static float[] Exercise3(float[] arr1, float[] arr2)
        {
            //Console.WriteLine("Ham cong gia tri 2 mang khac do dai voi nhau voi nhau");
            //int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            //int[] arr2 = new int[] { 6, 15, -45, 0, 6, 5, 7, 3 };
            //int shorterLength = Math.Min(arr1.Length, arr2.Length);
            //int longerLength = Math.Max(arr1.Length, arr2.Length);
            //int[] newArr = new int[longerLength];

            //for (int i = 0; i < shorterLength; i++)
            //{
            //    newArr[i] = arr1[i] + arr2[i];
            //}

            //for (int i = shorterLength; i < longerLength; i++)
            //{
            //    if (arr1.Length > arr2.Length)
            //    {
            //        newArr[i] = arr1[i];
            //    }

            //    else
            //    {
            //        newArr[i] = arr2[i];
            //    }
            //}
            //Console.Write("Mang moi: ");
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.Write(newArr[i] + " ");
            //}

            float[] newArr = new float[arr1.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] + arr2[i];
            }
            return newArr;
        }
        static void Exercise3Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 3f }, new float[] { 2f, 5f, 6f }, "Test case medium 03 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 9f, -1f, -4f, 12f, 3f }, "Test case medium 03 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.75f, -3.65f, 78f, -5.5f, -8f }, new float[] { 7.75f, -5.35f, -2f, 2.5f, 78f }, new float[] { 6f, -9f, 76f, -3f, 70f }, "Test case medium 03 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise3((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Minus array of the same size
        static float[] Exercise4(float[] arr1, float[] arr2)
        {
            float[] newArr = new float[arr1.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] - arr2[i];
            }
            return newArr;
        }
        static void Exercise4Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 6f }, new float[] { 0f, -1f, -3f }, "Test case medium 04 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { -5f, 9f, -8f, 4f, -13f }, "Test case medium 04 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.75f, -3.65f, 78f, -5.5f, -8f }, new float[] { 7.75f, -5.65f, -2f, 2.5f, 78f }, new float[] { -9.5f, 2f, 80f, -8f, -86f }, "Test case medium 04 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise4((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Multiphy array of the same size
        static float[] Exercise5(float[] arr1, float[] arr2)
        {
            float[] newArr = new float[arr1.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] * arr2[i];
            }
            return newArr;
        }
        static void Exercise5Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 6f }, new float[] { 1f, 6f, 18f }, "Test case medium 05 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 14f, -20f, -12f, 32f, -40f }, "Test case medium 05 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.75f, -2.5f, 8f, -8f, 8f }, new float[] { 2f, 2.5f, -2f, 2.5f, 8f }, new float[] { -3.5f, -6.25f, -16f, -20f, 64f }, "Test case medium 05 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise5((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Divide array of the same size
        static float[] Exercise6(float[] arr1, float[] arr2)
        {
            float[] newArr = new float[arr1.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] / arr2[i];
            }
            return newArr;
        }
        static void Exercise6Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 6f, 18f }, new float[] { 1f, 3f, 6f }, new float[] { 1f, 2f, 3f }, "Test case medium 06 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 14f, -20f, -12f, 32f, -40f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 2f, 4f, -6f, 8f, -5f }, "Test case medium 06 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -3.5f, -6.25f, -16f, -20f, 64f }, new float[] { 2f, 2.5f, -2f, 2.5f, 8f }, new float[] { -1.75f, -2.5f, 8f, -8f, 8f }, "Test case medium 06 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise6((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        //Get a number of elements of an array of numbers based on the beginning and the end
        static float[] Exercise7(float[] arr, int start, int end)
        {
            int newArrLength = end - start;
            float[] newArr = new float[newArrLength];
            for (int i = 0; i < newArrLength; i++)
            {
                newArr[i] = arr[i + start];
            }
            return newArr;
        }
        static void Exercise7Test()
        {
            object[] testData1 = new object[] { new float[] { 1f, 6f, 18f, 14f, -20f, -12f, 32f, -40f }, 3, 8, new float[] { 14f, -20f, -12f, 32f, -40f }, "Test case medium 07 - 01 - mang so nguyen duong va am" };
            object[] testData2 = new object[] { new float[] { -3.5f, -6.25f, -16f, -20f, 64f, -12f, 32f, -40f }, 2, 6, new float[] { -16f, -20f, 64f, -12f }, "Test case medium 07 - 02 - mang so thap phan" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(Exercise7((float[])testDataItem[0], (int)testDataItem[1], (int)testDataItem[2]), (float[])testDataItem[3]), (string)testDataItem[4]);
            }
        }
        //Position of first occurrence of string a in string b
        static int Exercise8(string str1, string str2)
        {
            int index = -1;
            for (int i = 0; i <= str2.Length - str1.Length; i++)
            {
                int j;
                for (j = 0; j < str1.Length; j++)
                {
                    if (str2[i + j] != str1[j])
                    {
                        break;
                    }
                }
                if (j == str1.Length)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        static void Exercise8Test()
        {
            object[] testData1 = new object[] { "football", "results football english premier league", 8, "Test case medium 08 - 01 - chua doan string" };
            object[] testData2 = new object[] { "results football english premier league", "rtytr", -1, "Test case medium 08 - 01 - khong chua doan string" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise8((string)testDataItem[0], (string)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Calculate the total number of elements of string a in string b
        public static int Exercise9(string arr1, string arr2)
        {
            int count = 0;
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;

            for (int i = 0; i <= lengthArr1 - lengthArr2; i++)
            {
                int j;
                for (j = 0; j < lengthArr2; j++)
                {
                    if (arr1[i + j] != arr2[j])
                    {
                        break;
                    }
                }
                if (j == lengthArr2)
                {
                    count++;
                }
            }

            return count;
        }
        static void Exercise9Test()
        {
            object[] testData1 = new object[] { "day la chuoi chuoi chuoi chinh", "chuoi", 3, "Test case medium 09 - 01 - chuoi b có ton tai trong chuoi a" };
            object[] testData2 = new object[] { "day la chuoi chuoi chuoi chinh", "may", 0, "Test case medium 09 - 02 - chuoi b khong có trong chuoi a" };


            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise9((string)testDataItem[0],(string)testDataItem[1])== (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Calculate the total number of elements of the string a that are not in the string b
        //Số phần tử của chuỗi a không có trong chuỗi b
        public static int Exercise10(string a, string b)
        {
            int count = 0;

            // Tạo một mảng đếm số lần xuất hiện của mỗi ký tự trong chuỗi b
            int[] charCount = new int[256];
            for (int i = 0; i < b.Length; i++)
            {
                charCount[b[i]]++;
            }

            // Kiểm tra từng ký tự trong chuỗi a
            for (int i = 0; i < a.Length; i++)
            {
                // Nếu ký tự không xuất hiện trong chuỗi b, tăng biến đếm count lên 1
                if (charCount[a[i]] == 0)
                {
                    count++;
                }
            }

            return count;
        }
        static void Exercise10Test()
        {
            object[] testData1 = new object[] { "abcdefg", "cdehij", 4, "Test case medium 10 - 01 - chuoi a có ton tai trong chuoi b" };
            object[] testData2 = new object[] { "loujwy", "abcdefg", 6, "Test case medium 10 - 02 - chuoi a khong có trong chuoi b" };
            object[] testData3 = new object[] { "loujjjjeeewy", "abcdefg", 9, "Test case medium 10 - 03 - chuoi a co gia tri lap khong có trong chuoi b" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise10((string)testDataItem[0], (string)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Random between 0 and a
        static bool Exercise11(int a)
        {
            bool check = true;
            Random random = new Random();
            // sử dụng hàm random() để tạo giá trị ngẫu nhiên từ 0 đến 1
            double randomValue = random.NextDouble();
            // chuyển giá trị ngẫu nhiên từ 0 đến 1 thành giá trị trong khoảng từ 0 đến a
            double randomInRange = randomValue * a;

            if (a >= 0 && (randomInRange < 0 || randomInRange > a))
            {
                check = false;
            }
            else if (a < 0 && (randomInRange >= 0 || randomInRange < -a))
            {
                check = false;
            }
            return check;
        }
        static void Exercise11Test()
        {
            object[] testData1 = new object[] { 4, true, "Test case medium 11 - 01 - so duong" };
            object[] testData2 = new object[] { 0, true, "Test case medium 11 - 02 - so 0" };
            object[] testData3 = new object[] { -5, false, "Test case medium 11 - 03 - so am" };//???

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise11((int)testDataItem[0]) == (bool)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Random between -a and a
        static bool Exercise12(int a)
        {
            bool check = true;
            Random random = new Random();
            double randomValue1 = random.NextDouble();
            double randomValue2 = random.NextDouble();
            double result = (randomValue1 * a) - (randomValue2 * a);

            if (result < -a || result > a)
            {
                check = false;
            }
            return check;
        }
        static void Exercise12Test()
        {
            object[] testData1 = new object[] { 4, true, "Test case medium 12 - 01 - so duong" };
            object[] testData2 = new object[] { 0, true, "Test case medium 12 - 02 - so 0" };
            object[] testData3 = new object[] { -5, false, "Test case medium 12 - 03 - so am" };//???

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise12((int)testDataItem[0]) == (bool)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Calculate the price of the motel
        static int Exercise13(int checkin, int checkout)
        {
            int money = 0;
            if (checkin < 24 && checkout <= 24 && checkin >= 0 && checkout >= 0 && checkin % 1 == 0 && checkout % 1 == 0)
            {
                if (checkout < checkin && checkout > 8 && 24 - checkin > 2)
                //using the room overnight and pay > 8:00.am and set room > 22:00 pm
                {
                    return money = 140000 + (22 - checkin) * 50000 + 160000 + (checkout - 8) * 40000;
                }
                if (checkout < checkin && checkout <= 8 && checkin < 24 && 24 - checkin <= 2)
                //using the room overnight and pay <= 8:00.am and set room <= 22:00 pm
                {
                    return money = 160000 + (24 - checkin) * 70000;
                }
                else if (checkout < checkin && checkout <= 8 && checkin < 24 && 24 - checkin >= 2)
                //using the room overnight and pay <= 8:00.am and set room >= 22:00 pm
                {
                    return money = 160000 + 140000 + (24 - checkin - 2) * 50000;
                }
                else if (checkout < checkin && checkout > 8)//using the room overnight and pay after 8:00.am
                {
                    return money = 160000 + (checkout - 8) * 40000;
                }
                else if (checkout - checkin <= 2)//using the room less than 2 hours
                {
                    return money = (checkout - checkin) * 70000;
                }
                if ((checkout - checkin) > 2)//using the room greater than 2 hours
                {
                    return money = 140000 + (checkout - checkin - 2) * 50000;
                }
            }
            else
            {
                return -1;
            }
            return money;
        }
        static void Exercise13Test()
        {
            object[] testData1 = new object[] { 7, 9, 140000, "Test case medium 13 - 01 - 2 tieng" };
            object[] testData2 = new object[] { 7, 12, 290000, "Test case medium 13 - 02 - lon hon 2 tieng" };
            object[] testData3 = new object[] { -5, 1, -1, "Test case medium 13 - 03 - so am" };
            object[] testData4 = new object[] { 22, 8, 300000, "Test case medium 13 - 03 - qua dem" };

            object[][] testData = new object[4][] { testData1, testData2, testData3, testData4 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise13((int)testDataItem[0], (int)testDataItem[1]) == (int)testDataItem[2], (string)testDataItem[3]);
            }
        }
        //Calculate the amount of tax payable in n months of a person
        static int Exercise14(int[] incomePersonInMonth)
        {
            int tax;
            int sum = 0;
            for (int i = 0; i < incomePersonInMonth.Length; i++)
            {
                if (incomePersonInMonth[i] < 0)
                {
                    return -1;
                }
                else if (incomePersonInMonth[i] > 50000000)
                {
                    tax = incomePersonInMonth[i] * 20 / 100;
                    sum += tax;
                }
                else if (incomePersonInMonth[i] > 20000000 && incomePersonInMonth[i] < 50000000)
                {
                    tax = incomePersonInMonth[i] * 10 / 100;
                    sum += tax;
                }
                else if (incomePersonInMonth[i] < 20000000)
                {
                    tax = incomePersonInMonth[i] * 5 / 100;
                    sum += tax;
                }
            }
            return sum;
        }
        static void Exercise14Test()
        {
            object[] testData1 = new object[] { new int[] { 60000000, 30000000, 10000000 }, 15500000, "Test case medium 14 - 01 - tien nguyen nguyen duong" };
            object[] testData2 = new object[] { new int[] { 60000000, 30000000, -10000000 }, -1, "Test case medium 04 - 02 - tien nguyen am" };
            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise14((int[])testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Sum of digits of an integer
        static int Exercise15(int num)
        {
            if (num < 0)
            {
                num = num * -1;
            }
            string str = Convert.ToString(num);
            int[] arr = new int[str.Length];
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = Int32.Parse(str[i].ToString());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        static void Exercise15Test()
        {
            object[] testData1 = new object[] { 4879, 28, "Test case medium 15 - 01 - so duong" };
            object[] testData2 = new object[] { -23476, 22, "Test case medium 15 - 02 - so 0" };
            object[] testData3 = new object[] { 0, 0, "Test case medium 15 - 03 - so am" };//???

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise15((int)testDataItem[0]) == (int)testDataItem[1], (string)testDataItem[2]);
            }
        }
        //Sum of digits of an integer
        static int Exercise16(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Exercise16(n - 1) + Exercise16(n - 2);
            }
        }
        static void Exercise16Test()
        {

        }
        //Cut string by start position and end position
        static string Exercise17(string str, int pointStart, int pointEnd)
        {
            if (pointStart == pointEnd)
            {
                return "";
            }
            string newarr = "";
            for (int i = pointStart; i <= pointEnd; i++)
            {
                newarr += str[i];
            }
            return newarr;
        }
        static void Exercise17Test()
        {
            object[] testData1 = new object[] { "It should only contain three elements", 5, 10, "ould o", "Test case medium 17 - 01 - normal" };
            object[] testData2 = new object[] { "It should only contain three elements", 5, 5, "", "Test case medium 17 - 02 -  vi tri bat dau bang vi tri ket thuc" };

            object[][] testData = new object[2][] { testData1, testData2 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise17((string)testDataItem[0], (int)testDataItem[1], (int)testDataItem[2]) == (string)testDataItem[3], (string)testDataItem[4]);
            }
        }
        //Cut a string by the starting position and the number of characters to cut
        static string Exercise18(string str, int pointStart, int next)
        {
            string newarr = "";
            for (int i = pointStart; i <= next + pointStart; i++)
            {
                newarr += str[i];
            }
            return newarr;
        }
        static void Exercise18Test()
        {
            object[] testData1 = new object[] { "It should only a contain three elements", 5, 10, "ould only a", "Test case medium 18 - 01 - so duong" };
            object[] testData2 = new object[] { "It should only contain three elements", 5, 0, "", "Test case medium 18 - 02 -  vi tri next bang 0" };

            object[][] testData = new object[1][] { testData1 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Exercise18((string)testDataItem[0], (int)testDataItem[1], (int)testDataItem[2]) == (string)testDataItem[3], (string)testDataItem[4]);
            }
        }
    }

}
