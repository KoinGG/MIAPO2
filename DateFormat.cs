using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAPO
{
    public class DateFormat
    {
        public static void ConvertDateFormat()
        {
            Console.Write("\n Введите дату в формате дд.мм.гггг: ");
            string date = Console.ReadLine();

            string[] dateParts = date.Split('.'); 
            string month = dateParts[1]; 
            string day = dateParts[0]; 
            string year = dateParts[2]; 
            string newDate = month + "/" + day + "/" + year;

            Console.WriteLine($" Ваша дата в формате мм/дд/гггг - {newDate}");
        }
    }
}
