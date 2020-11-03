using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Car
    {
       readonly private string CarName;
       readonly private int CarYear;
        public Car()
        {
            CarName = "";
            CarYear = 0;
        }
        public Car(string carname, int year)
        {
            CarName = carname;
            CarYear = year;
        }
       public string Name
        {
            get { return CarName; }
        }
        public int Year
        {
            get { return CarYear; }
        }

        public void Show()
        {
            Console.WriteLine("Название машины: {0}, Год выпуска: {1}",CarName,CarYear);
        }
        
    }
}
