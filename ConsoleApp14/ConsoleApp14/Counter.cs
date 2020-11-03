using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp14
{
    class Counter
    {
        static public int a = 0; //Суммироемое число
       static public Object block = new object();//Объект блокировки
        public void Num() //Суммирует число со случайным числом 
        {
            lock (block)  //Ждем пока отработается наш поток 
            {  
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    a = a + rand.Next(0, 1000);
                    Console.WriteLine("Thread ID {0},   {1}", Thread.CurrentThread.GetHashCode(), a);
                }
                Console.WriteLine(new string('-', 20));
            }
            
        }

    }
}
