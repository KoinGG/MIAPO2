using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO
{
    public class Palindrome
    {
        public static void IsPalindrome()
        {
            Console.Write("\nВведите текст для проверки на палиндром: ");
            string text = Console.ReadLine();

            string reversedText = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }

            if(text == reversedText)
            {
                Console.WriteLine("\nТекст является палиндромом");
            }
            else
            {
                Console.WriteLine("\nТекст не является палиндромом");
            }
        }
    }
}
