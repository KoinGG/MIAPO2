using System;

namespace MIAPO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Again:

            Console.WriteLine("\n МЕНЮ \n");
            Console.WriteLine(" 1) Генерация случайного числа\n" +
                              " 2) Конвертирование даты\n" +
                              " 3) Проверка текста на палиндром\n" +
                              " 4) Подсчет цены с учетом скидки");

            int menuChoise = int.Parse(Console.ReadLine());

            switch(menuChoise)
            {
                case 1: 
                    {
                        Console.Clear();

                        RandomNumber.GenerateRandomNumber();
                        Thread.Sleep(2000);

                        Console.Clear();
                        break;
                    };
                case 2:
                    {
                        Console.Clear();

                        DateFormat.ConvertDateFormat();
                        Thread.Sleep(2000);

                        Console.Clear();
                        break;
                    };
                case 3:
                    {
                        Console.Clear();

                        Palindrome.IsPalindrome();
                        Thread.Sleep(2000);

                        Console.Clear();
                        break;
                    };                    
                case 4:
                    {
                        Console.Clear();

                        TotalCost.CalculateTotalCost();
                        Thread.Sleep(2000);

                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.Clear();

                        Console.WriteLine("\n Выберите что-то существующее");
                        Thread.Sleep(1500);

                        Console.Clear();

                        break;
                    }
            }

            goto Again;

        }
    }
}