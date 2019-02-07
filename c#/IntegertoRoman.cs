// Source : https://leetcode.com/problems/integer-to-roman/ 
// Author : codeyu 
// Date : 10/4/16 

/***************************************************************************************
*
* Given an integer, convert it to a roman numeral.
* 
* Input is guaranteed to be within the range from 1 to 3999.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
namespace Algorithms
{
    public class Solution012
    {
        // <$ tag="integer,roman,c#,test" description="Given an integer, convert it to a roman numeral." $$
        public static string IntToRoman(int num)
        {
            if (num < 0 || num > 3999)
            {
                return "";
            }
            string str = "";
            string[] symbol = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] value = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            for (int i = 0; num != 0; i++)
            {
                while (num >= value[i])
                {
                    num -= value[i];
                    str += symbol[i];
                }
            }
            return str;

        }
        // $>

        // <$ tag="integer,roman,c#,test" description="Given an integer, convert it to a roman numeral. Method 2" $$
        public static string IntToRoman2(int num)
        {
            char[] symbol = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            StringBuilder roman = new StringBuilder();
            int scale = 1000;
            int p = 6;
            while (num > 0)
            {
                int digit = num / scale;
                if (digit > 0 && digit < 10)
                {
                    roman.Append(RomanStr(digit, symbol, p));
                }
                num = num % scale;
                scale /= 10;
                p -= 2;
            }
            return roman.ToString();
        }
        private static string RomanStr(int digit, char[] symbol, int p)
        {
            StringBuilder roman = new StringBuilder();
            if (digit <= 3) roman.Append(symbol[p], digit);
            else if (digit == 4)
            {
                roman.Append(symbol[p]);
                roman.Append(symbol[p + 1]);
            }
            else if (digit <= 8)
            {
                roman.Append(symbol[p + 1]);
                roman.Append(symbol[p], digit - 5);
            }
            else if (digit == 9)
            {
                roman.Append(symbol[p]);
                roman.Append(symbol[p + 2]);
            }
            return roman.ToString();
        }
        // $>
    }
}
