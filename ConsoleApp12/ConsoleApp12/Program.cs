using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           CarCollection<Car>.N =  Convert.ToInt32(Console.ReadLine());
            CarCollection<Car> cars = new CarCollection<Car>();
            for(int i = 0; i < cars.Length; i++)
            {
                cars.AddCar(new Car(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
                ((Car)cars[i]).Show();
            }
            Console.WriteLine("Машин до покупки: {0}", cars.Count);
            cars.Search(Convert.ToInt32(Console.ReadLine())).Show();
            cars.DeleteCars();
            Console.WriteLine("Машин после покупки: {0}", cars.Count);
            cars.ShowAll();
            Console.ReadKey();
        }
    }
}
