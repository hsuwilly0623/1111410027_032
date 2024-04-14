using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410027_許哲瑋032
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數（1 到 3999）："); // 提示使用者輸入一個整數
            int num = Convert.ToInt32(Console.ReadLine()); // 從使用者獲取輸入的整數並轉換成整數型態
            Console.WriteLine(IntToRoman(num)); // 輸出轉換後的羅馬數字
        }
        public static string IntToRoman(int num)
        {
            string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };  // 將整數轉換為羅馬數字的方法
            int[] romanValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };                       // 定義羅馬數字的符號和對應的值

            StringBuilder roman = new StringBuilder();                                                          // 用於構建羅馬數字的 StringBuilder 對象


            for (int i = 0; i < romanSymbols.Length; i++)                                                       // 迭代處理每個羅馬數字符號
            {
                while (num >= romanValues[i])                                                                   // 持續減去對應的值直到 num 為 0
                {
                    num -= romanValues[i];
                    roman.Append(romanSymbols[i]);
                }
            }

            return roman.ToString();                                                                             // 返回轉換後的羅馬數字
        }
    }
}
