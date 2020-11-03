using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp19
{
    class Collection : IEnumerable, IEnumerator, IDisposable
    {
        Month[] months = new Month[0];  //Изначально пустой массив при создании

        public Month this[int index]   //Индексатор 
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        int pos = -1; //Позиция в коллекции 

       public bool MoveNext() //Метод передвижения на следующую позицию
        {
            if(pos<months.Length-1)
            {
                pos++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

       public object Current //Вывод элемента коллекции на текущей позиции
        {
            get { return months[pos]; }
        }

       public IEnumerator GetEnumerator() 
        {
            return (IEnumerator)this;
        }

       public void Reset()  //Сброс позиции
        {
            pos = -1;
        }

        public void Dispose()  
        {
            ((IEnumerator)this).Reset();
        }

        public void Add(Month value) //Добавляет элемент в массив (динамически)
        {
            if (months.Length == pos + 1)
            {
                var newArray = new Month[2*months.Length + 1];
                months.CopyTo(newArray, 0);
                newArray[pos + 1] = value;
                months = newArray;
                this.MoveNext();
            }
            else
            {
                this.MoveNext();
                this.months[pos] = value;
            }
        }

        public void Clear() //Очищает массив
        {
            months = new Month[0];
        }

        public Month Search(int index) //Поиск месяца по номеру
        {
            foreach(Month month in months)
            {
                if (month != null && month.Number == index )
                {
                    
                    return month;
                }
                
            }
                return new Month("Нет такого месяца",0,0);
        }

        public ArrayList SearchByDays(int days)   //Поиск всех месяцев с данным количеством дней 
        {
            ArrayList matchedMonths = new ArrayList();
            foreach (Month month in months)
                if (month != null && month.Days == days) matchedMonths.Add(month);
            if (matchedMonths.Capacity == 0) Console.WriteLine("Таких месяцев нет");
            return matchedMonths;
        }

        public void Show() // Вывод всех месяцев на экран
        {
            foreach(Month month in months)
            {
                if(month!=null)
                month.Show();
            }
        }
    }
}
