using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    internal class Program
    {
        static string[] ones = {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        static string[] tens = {
            "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập số từ người dùng
            Console.Write("Nhập số: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Hiển thị số thành chữ
            Console.WriteLine("Số {0} được viết thành chữ là: {1}", number, ConvertNumberToWords(number));

            // Dừng màn hình console để người dùng có thể xem kết quả
            Console.ReadLine();
        }
        static string ConvertNumberToWords(int number)
        {
            if (number < 20)
            {
                return ones[number];
            }

            if (number < 100)
            {
                return tens[number / 10] + (number % 10 != 0 ? " " + ones[number % 10] : "");
            }

            if (number < 1000)
            {
                return ones[number / 100] + " hundred" + (number % 100 != 0 ? " " + ConvertNumberToWords(number % 100) : "");
            }

            if (number < 1000000)
            {
                return ConvertNumberToWords(number / 1000) + " thousand" + (number % 1000 != 0 ? " " + ConvertNumberToWords(number % 1000) : "");
            }

            if (number < 1000000000)
            {
                return ConvertNumberToWords(number / 1000000) + " million" + (number % 1000000 != 0 ? " " + ConvertNumberToWords(number % 1000000) : "");
            }

            return ConvertNumberToWords(number / 1000000000) + " billion" + (number % 1000000000 != 0 ? " " + ConvertNumberToWords(number % 1000000000) : "");
        }
    }
}
