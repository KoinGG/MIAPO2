using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO
{
    public class RandomNumber
    {
        public static void GenerateRandomNumber()
        {
            Console.Write("Введите минимальное число: ");
            int minNum = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное число: ");
            int maxNum = int.Parse(Console.ReadLine());

            Random random = new Random(); 
            int randomNumber = random.Next(minNum, maxNum);

            Console.WriteLine($"\nВаше случайное число: {randomNumber}");
        }
    }
}
