using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO
{
    public class TotalCost
    {
        public static void CalculateTotalCost()
        {
            Console.Write("\nВведите цену товара: ");
            double price = Double.Parse(Console.ReadLine());

            Console.Write("Введите процент скидки: ");
            double discountAmount = Double.Parse(Console.ReadLine());
            discountAmount = price * (discountAmount / 100);

            double totalCost = price - discountAmount;

            Console.WriteLine($"Цена с учетом скидки = {totalCost}");
        }
    }
}
