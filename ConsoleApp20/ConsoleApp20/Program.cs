using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp20
{
    class Program : KeyValueCompare
    {
        static void Main(string[] args)
        {
            var hash = new Hashtable(new OrderedDictionary()); //Коллекция с возможностью сравнения ключей

            hash["tru"] = "1";
            hash["Tru"] = "2";
            hash["try"] = "2";
            
           foreach(var a in hash.Values)  //Вывод на экран значений всех различных ключей
            {
                Console.WriteLine(a);
            }
            KeyValueCompare b = new KeyValueCompare();
            Console.WriteLine("Всего различных ключей: {0}",hash.Count);
            Console.WriteLine(b.CompareHash(hash["tru"],hash["try"]));
            Console.ReadKey();
        }
    }
}
