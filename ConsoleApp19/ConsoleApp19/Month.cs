using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Month
    {
        string _Name;
        int _Days;
        int _Number;
        public Month()  //Конструкторы 
        {
            _Number = 0;
            _Days = 0;
            _Name = " ";
        }
        public Month(string name, int days, int number) 
        {
            _Name = name;
            _Days = days;
            _Number = number;
        }
        public string Name //Возвращает название месяца
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Days //Возвращает количество дней в месяце
        {
            get { return _Days; }
            set { _Days = value; }
        }
        public int Number // Возвращает номер месяца
        {
            get { return _Number; }
            set { _Number = value; }
        }

        public void Show() //Метод вывода на экран
        {
            Console.WriteLine("Дней в месяце: {0}, Номер месяца: {1}, Название месяца: {2}", _Days, _Number, _Name);
        }
    }
}
