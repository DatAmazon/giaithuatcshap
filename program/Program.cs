using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcdefg";
            string b = "cdehij";
            int result = CountMissingElements(a, b);
            Console.WriteLine("So phan tu trong chuoi a khong co trong chuoi b la: " + result);
        }
        public static int CountMissingElements(string a, string b)
        {
            int count = 0;
            int[] charCount = new int[256];
            for (int i = 0; i < b.Length; i++)
            {
                charCount[b[i]]++;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (charCount[a[i]] == 0)
                {
                    count++;
                }
            }
            return count;
        }

    }

}
