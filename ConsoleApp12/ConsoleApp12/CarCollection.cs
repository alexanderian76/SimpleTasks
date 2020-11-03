using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class CarCollection<T>
    {
       public static int N;
        public int Length //Возвращает длину массива
        {
            get
            {
                return N;
            }
        }
        ArrayList array = new ArrayList();
        public void AddCar(T car)
        {
            array.Add(car);
        }
        public Object this[int index]
        {
            get { return array[index]; }
            set { if (index < array.Count) array[index] = value; }
            }
       public T Search(int i)
        {
            return (T)this[i];
        }
        public int Count
        {
            get { return array.Count;}
        }
        public void DeleteCars()
        {
            array.Clear();

        }
        public void ShowAll()
        {
            if (array.Count != 0)
            {
                for (int i = 0; i < this.Count; i++)
                {
                     ((Car)array[i]).Show();
                }
            }
            else
            {
                Console.WriteLine("Пусто");
            }
        }
    }
}
