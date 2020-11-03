using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection year = new Collection { new Month("Январь", 31, 1), new Month("Февраль", 28, 2), new Month("Март",31,3), new Month("Апрель", 30, 4), new Month("Май", 31, 5), new Month("Июнь", 30, 6), new Month("Июль", 31, 7), new Month("Август", 31, 8), new Month("Сентябрь", 30, 9), new Month("Октябрь", 31, 10), new Month("Ноябрь", 30, 11), new Month("Декабрь", 31, 12)};
            year.Show();
            Console.WriteLine("Поиск по номеру месяца");
            year.Search(Convert.ToInt32(Console.ReadLine())).Show();
            Console.WriteLine("Поиск по количеству дней месяца");
            foreach (Month month in year.SearchByDays(Convert.ToInt32(Console.ReadLine())))
            { 
                month.Show();
            }

            Console.ReadKey();
        }
    }
}
