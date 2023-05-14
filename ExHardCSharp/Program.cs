using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHardCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("------------o0o-----------");
                Console.Write("Moi ban nhap cau can kiem tra: ");
                input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("dao nguoc ky tu tung tu trong cau");
                        Console.Write("Nhap cau: ");
                        string sentence = Console.ReadLine();
                        Console.WriteLine(ReverseWordsInSentence(sentence));
                        break;
                    case 2:
                        Console.WriteLine("Random so trong khoang a, b");
                        Console.Write("Nhap so nguyen a: ");
                        int a = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap so nguyen b: ");
                        int b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(randomRange(a, b));
                        break;
                    case 3:
                        concatTwoArrAndSortAscending();
                        break;
                    case 4:
                        concatArrSortDescending();
                        break;
                    case 5:
                        Function5();
                        break;
                    case 6:
                        Function6();
                        break;
                    case 7:
                        Console.Write("Nhap so tien: ");
                        int money = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(ConvertCurrencyToWords(money));
                        break;
                    case 8:
                        Console.Write("Nhap so tien: ");
                        int money8 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(findNumberMinMoney(money8)); 
                        break;
                    case 9:
                        Console.WriteLine("Dem so lan xuat hien chuoi a trong chuoi b: ");
                        Console.Write("Nhap chuoi a: ");
                        string str1 = Console.ReadLine();
                        Console.Write("Nhap so nguyen b: ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine(CountOccurrences(str1, str2));
                        break;

                    case 10:
                        Console.Write("Ket qua sau khi xao tron cac phan tu trong mang: ");
                        int[] arr = new int[] { 4, -3, 0, 6, 15, -45, 9, 4 };
                        Shuffle(arr);
                        break;
                    case 11:
                        Console.WriteLine("Lay so cuoi cung khac 0 cua n giai thua ");
                        Console.Write("Nhap so n: ");
                        int n11 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(returnsLastNumberFactorial(n11));
                        break;
                    case 12:
                        Console.WriteLine("Dem so  0 cua n giai thua ");
                        Console.Write("Nhap so n: ");
                        int n12 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(countAppear0InFactorial(n12));
                        break;
                    case 0:
                        Console.WriteLine("");
                        Console.WriteLine("Da thoat");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (input != 0);

        }

        static string ReverseWordsInSentence(string str)
        {
            //string[] words = sentence.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    char[] chars = words[i].ToCharArray();
            //    Array.Reverse(chars);
            //    words[i] = new string(chars);
            //}

            //return string.Join(" ", words);


            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            //reverse characters in string
            {
                newStr += str[i];
            }
            string[] strSplit = newStr.Split(' ');// cut string by character ' '
            string strFinish = "";
            for (int i = strSplit.Length - 1; i >= 0; i--)//reverse characters in words in string
                if (i > 0)
                {
                    strFinish += strSplit[i] + " ";
                }
                else
                {
                    strFinish += strSplit[i];
                }
            return (strFinish);
        }

        static double randomRange(int a, int b)
        {
            Random random = new Random();
            double randomValue = random.NextDouble();
            double result = a + (randomValue * (b - a));
            return result;
        }
        static void concatTwoArrAndSortAscending()
        {
            Console.WriteLine("Noi 2 mang va sap xep theo theo chieu tang dan");
            int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            int[] arr2 = new int[] { 6, 15, -45, 3, 7, 34, 31, 6 };
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            int[] newArr = new int[lengthTotal];

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
                        int temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }

        }
        static void concatArrSortDescending()
        {
            Console.WriteLine("Noi 2 mang va sap xep theo theo chieu giam dan");
            int[] arr1 = new int[] { 4, -3, 0, 6, 15, -45 };
            int[] arr2 = new int[] { 6, 15, -45, 3, 7, 34, 31, 6 };
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            int lengthTotal = lengthArr1 + lengthArr2;
            int[] newArr = new int[lengthTotal];


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
                        int temp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        static void Function5()
        {

        }
        static void Function6()
        {

        }

        public static string ConvertCurrencyToWords(double amount)
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
                words += "Am ";
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
        static string findNumberMinMoney(int total)
        {
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
        static int CountOccurrences(string a, string b)
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

        public static void Shuffle(int[] arr)
        {
            Random rand = new Random();
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " "); ;
            }

        }

        static int returnsLastNumberFactorial(int n)
        {
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
        static int countAppear0InFactorial(int n)
        {
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
    }
}
