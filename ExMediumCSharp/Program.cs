using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMediumCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input;
            //do
            //{
            //    Console.WriteLine("------------o0o-----------");
            //    Console.Write("Moi ban nhap cau can kiem tra: ");
            //    input = Int32.Parse(Console.ReadLine());

            //    switch (input)
            //    {
            //        case 1:
            //            sortArrayAscending();
            //            break;
            //        case 2:
            //            concatArr();
            //            break;
            //        case 3:
            //            sumTwoArr();
            //            break;
            //        case 4:
            //            minusTwoArr();
            //            break;
            //        case 5:
            //            multiplyTwoArr();
            //            break;
            //        case 6:
            //            divideTwoArr();
            //            break;
            //        case 7:
            //            Console.WriteLine("Lay phan tu trong mang theo vi tri bat dau & ket thuc");
            //            Console.Write("Nhap vi tri bat dau: ");
            //            int start = Int32.Parse(Console.ReadLine());
            //            Console.Write("Nhap vi tri ket thuc: ");
            //            int end = Int32.Parse(Console.ReadLine());
            //            getElementArrayByLocation(start, end);
            //            break;
            //        case 8:
            //            Console.WriteLine("Tim vi tri xuat hien dau tien cua chuoi a trong chuoi b");
            //            Console.Write("Nhap chuoi a: ");
            //            string str8_1 = Console.ReadLine();
            //            Console.Write("Nhap chuoi b: ");
            //            string str8_2 = Console.ReadLine();
            //            LocationFirstStringAInStringB(str8_1, str8_2);
            //            break;
            //        case 9:
            //            Function9();
            //            break;

            //        case 10:
            //            Function10();
            //            break;
            //        case 11:
            //            Console.WriteLine("Random trong 1 khoang tu 0 -> a");
            //            Console.Write("Nhap so a: ");
            //            int a11 = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine(getRandom0ToA(a11));
            //            break;
            //        case 12:
            //            Console.WriteLine("Random trong 1 khoang tu -a -> a");
            //            Console.Write("Nhap so a: ");
            //            int a12 = Int32.Parse(Console.ReadLine());
            //            getRandomnNegativeAToPositiveA(a12);
            //            break;
            //        case 13:
            //            Console.Write("Nhap gio vao");
            //            int checkin = Int32.Parse(Console.ReadLine());
            //            Console.Write("Nhap gio ra");
            //            int checkout = Int32.Parse(Console.ReadLine());
            //            calculatePriceMotel(checkin, checkout);
            //            break;
            //        case 14:
            //            Console.WriteLine("Tinh tong tien thue phai nop");
            //            int[] incomeArr = new int[] { 60000000, 30000000, 10000000 };
            //            int totalTax = personalIncomeTax(incomeArr);
            //            Console.WriteLine("Tong so tien thue: " + totalTax);
            //            break;
            //        case 15:
            //            Console.WriteLine("Tong cac chu so cua 1 so nguyen a");
            //            Console.Write("Nhap so a: ");
            //            int a15 = Int32.Parse(Console.ReadLine());
            //            sumDigits(a15);
            //            break;
            //        case 16:
            //            Console.WriteLine("In ra n so dau tien cua day fibonacci");
            //            Console.Write("Nhap so n: ");
            //            int n = Int32.Parse(Console.ReadLine());
            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write(fibonacci(i) + " ");
            //            }
            //            break;

            //        case 17:
            //            Console.WriteLine("Cat chuoi theo vi tri bat dau va vi tri ket thuc");
            //            Console.Write("Nhap chuoi: ");
            //            string str = Console.ReadLine();
            //            Console.Write("Nhap vi tri bat dau: ");
            //            int pointStart = Int32.Parse(Console.ReadLine());
            //            Console.Write("Nhap vi tri ket thuc: ");
            //            int pointEnd = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine(cutStringByStartEndPosition(str, pointStart, pointEnd));
            //            break;
            //        case 18:
            //            Console.WriteLine("Cat chuoi theo vi tri bat dau va so ky tu can cat");
            //            Console.Write("Nhap chuoi: ");
            //            string str17 = Console.ReadLine();
            //            Console.Write("Nhap chuoi: ");
            //            int pointStart17 = Int32.Parse(Console.ReadLine());
            //            Console.Write("Nhap chuoi: ");
            //            int next = Int32.Parse(Console.ReadLine());
            //            Console.WriteLine(cutStringByStartPositionAndNumNextCut(str17, pointStart17, next));
            //            break;
            //        case 0:
            //            Console.WriteLine("");
            //            Console.WriteLine("Da thoat");
            //            Console.WriteLine("");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input.");
            //            break;
            //    }
            //} while (input != 0);
            sortArrayAscendingTest();
            concatArrTest();
            sumTwoArrTest();
            minusTwoArrTest();
            multiplyTwoArrTest();
            divideTwoArrTest();
            getElementArrayByLocationTest();
            LocationFirstStringAInStringBTest();

        }
        static float[] sortArrayAscending(float[] arr)
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

        static void sortArrayAscendingTest()
        {
            object[] testData1 = new object[] { new float[] { 1f, 3f, 2f }, new float[] { 1f, 2f, 3f }, "Test case easy 01 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { -6f, -5f, 2f, 4f, 8f }, "Test case easy 02 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -3.65f, -1.76f, 78f }, "Test case easy 03 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(sortArrayAscending((float[])testDataItem[0]), (float[])testDataItem[1]), (string)testDataItem[2]);
            }
        }

        static float[] concatArr(float[] arr1, float[] arr2)
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

        static void concatArrTest()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 3f }, new float[] { 1f, 2f, 3f, 1f, 3f, 3f }, "Test case easy 02 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 2f, 4f, -6f, 8f, -5f, 7f, -5f, 2f, 4f, 8f }, "Test case easy 02 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f }, new float[] { -7.9f, -5.78f, -3.65f, -1.76f, 78f }, new float[] { -1.76f, -3.65f, 78f, -5.78f, -7.9f, -7.9f, -5.78f, -3.65f, -1.76f, 78f }, "Test case easy 02 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(concatArr((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);

            }
        }
        static float[] sumTwoArr(float[] arr1, float[] arr2)
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
        static void sumTwoArrTest()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 3f }, new float[] { 2f, 5f, 6f }, "Test case easy 03 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { 9f, -1f, -4f, 12f, 3f }, "Test case easy 03 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.75f, -3.65f, 78f, -5.5f, -8f }, new float[] { 7.75f, -5.35f, -2f, 2.5f, 78f }, new float[] { 6f, -9f, 76f, -3f, 70f }, "Test case easy 03 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(sumTwoArr((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        static float[] minusTwoArr(float[] arr1, float[] arr2)
        {
            float[] newArr = new float[arr1.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] - arr2[i];
            }
            return newArr;
        }
        static void minusTwoArrTest()
        {
            object[] testData1 = new object[] { new float[] { 1f, 2f, 3f }, new float[] { 1f, 3f, 6f }, new float[] { 0f, -1f, -3f }, "Test case easy 04 - 01 - mang so nguyen duong" };
            object[] testData2 = new object[] { new float[] { 2f, 4f, -6f, 8f, -5f }, new float[] { 7f, -5f, 2f, 4f, 8f }, new float[] { -5f, 9f, -8f, 4f, -13f }, "Test case easy 04 - 02 - mang so nguyen duong va am" };
            object[] testData3 = new object[] { new float[] { -1.75f, -3.65f, 78f, -5.5f, -8f }, new float[] { 7.75f, -5.65f, -2f, 2.5f, 78f }, new float[] { -9.5f, 2f, 80f, -8f, -86f }, "Test case easy 04 - 03 - mang so thap phan" };

            object[][] testData = new object[3][] { testData1, testData2, testData3 };
            for (int i = 0; i < testData.Length; i++)
            {
                object[] testDataItem = testData[i];
                Debug.Assert(Enumerable.SequenceEqual(minusTwoArr((float[])testDataItem[0], (float[])testDataItem[1]), (float[])testDataItem[2]), (string)testDataItem[3]);
            }
        }
        static void multiplyTwoArr()
        {
            Console.WriteLine("Nhan 2 mang cung do dai voi nhau");
            int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            int[] arr2 = new int[] { 6, 15, -45, 0, 6, 5 };
            int[] newArr = new int[arr1.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] * arr2[i];
            }

            Console.Write("Mang moi: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        static void multiplyTwoArrTest()
        {

        }
        static void divideTwoArr()
        {
            Console.WriteLine("Chia 2 mang cung do dai voi nhau");
            float[] arr1 = new float[] { 4, -3, 0, 6, 15, -45 };
            float[] arr2 = new float[] { 6, 15, -45, 3, 6, 5 };
            float[] newArr = new float[arr1.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr1[i] / arr2[i];
            }

            Console.Write("Mang moi: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        static void divideTwoArrTest()
        {

        }
        static void getElementArrayByLocation(int start, int end)
        {
            Console.WriteLine("Lay so phan tu dua vao vi tri dau va cuoi");
            float[] arr = new float[] { 4, -3, 0, 6, 15, -45, 15, -45, 3, 6, 5 };
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
        static void getElementArrayByLocationTest()
        {

        }
        static void LocationFirstStringAInStringB(string str1, string str2)
        {
            int index = -1;

            //for (int i = 0; i <= str1.Length - str2.Length; i++)
            //{
            //    int j;
            //    for (j = 0; j < str2.Length; j++)
            //    {
            //        if (str1[i + j] != str2[j])
            //        {
            //            break;
            //        }
            //    }

            //    if (j == str2.Length)
            //    {
            //        index = i;
            //        break;
            //    }
            //}

            //if (index != -1)
            //{
            //    Console.WriteLine("vi tri dau tien cua chuoi '{0}' trong chuoi '{1}' là {2}", str2, str1, index);
            //}
            //else
            //{
            //    Console.WriteLine("khong tim thay chuoi '{0}' trong chuoi '{1}'", str2, str1);
            //}
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

            if (index != -1)
            {
                Console.WriteLine("vi tri dau tien cua chuoi '{0}' trong chuoi '{1}' là {2}", str1, str2, index);
            }
            else
            {
                Console.WriteLine("khong tim thay chuoi '{0}' trong chuoi '{1}'", str1, str2);
            }
        }
        static void LocationFirstStringAInStringBTest()
        {

        }


        static void Function9()
        {

        }

        static int calculatePriceMotel(int checkin, int checkout)
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
                Console.WriteLine("Parameter passed in must be a positive integer, checkin < 24 and checkout <= 24");
                return -1;
            }
            return money;
        }
        static void Function10()
        {

        }
        static double getRandom0ToA(int a)
        {
            Random random = new Random();
            // sử dụng hàm random() để tạo giá trị ngẫu nhiên từ 0 đến 1
            double randomValue = random.NextDouble();
            // chuyển giá trị ngẫu nhiên từ 0 đến 1 thành giá trị trong khoảng từ 0 đến a
            double randomInRange = randomValue * a;
            return randomInRange;
        }
        static void getRandomnNegativeAToPositiveA(int a)
        {
            Random random = new Random();
            double randomValue1 = random.NextDouble();
            double randomValue2 = random.NextDouble();
            double result = (randomValue1 * a) - (randomValue2 * a);
            Console.WriteLine(result);
        }
        static int personalIncomeTax(int[] incomePersonInMonth)
        {
            //int tax = 0;
            //if (incomePersonInMonth > 50000000)
            //{
            //    tax = incomePersonInMonth * 20 / 100;
            //}
            //else if (incomePersonInMonth > 20000000 && incomePersonInMonth < 50000000)
            //{
            //    tax = incomePersonInMonth * 10 / 100;
            //}
            //else if (incomePersonInMonth < 20000000)
            //{
            //    tax = incomePersonInMonth * 5 / 100;

            //}
            //return tax;

            int tax = 0;
            int sum = 0;
            for (int i = 0; i < incomePersonInMonth.Length; i++)
            {
                if (incomePersonInMonth[i] > 50000000)
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
        static void Function14()
        {

        }
        static void sumDigits(int num)
        {
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
            Console.WriteLine(sum);
        }
        static int fibonacci(int n)
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
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
        static string cutStringByStartEndPosition(string str, int pointStart, int pointEnd)
        {
            string newarr = "";
            for (int i = pointStart; i <= pointEnd; i++)
            {
                newarr += str[i];
            }
            return newarr;
        }
        static string cutStringByStartPositionAndNumNextCut(string str, int pointStart, int next)
        {
            string newarr = "";
            for (int i = pointStart; i <= next + pointStart; i++)
            {
                newarr += str[i];
            }
            return newarr;
        }
    }

}
