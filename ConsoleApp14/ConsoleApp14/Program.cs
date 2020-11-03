using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();
            while (true)
            {  
                    for (int i = 0; i < 5; i++) //5 раз суммируем по 5 раз
                    {
                        ThreadStart counter = new ThreadStart(count.Num);
                        new Thread(counter).Start();
                    }
                Console.ReadKey();
            }
        }
    }
}
