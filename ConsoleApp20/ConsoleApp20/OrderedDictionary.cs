using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp20
{
    class OrderedDictionary : IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();  //Сравнение элементов не учитывая регистр

        public int GetHashCode(object obj) //Метод получения хешкода
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }

        public new bool Equals(object a, object b) //Метод сравнения совпадают или нет
        {
            return comparer.Compare(a, b)==0;
        }
    }
}
