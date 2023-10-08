using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Parking parking = new Parking();

            car.Brand = "Toyota";
            car.Model = "Hilux";
            car.Number = "BH 1234 EA";
            car.Color = "Black";
            car.TimeWhichCarCame = "12:23";
            car.TimeWhichCarLeft = "17:12";

            parking.AddCarToTheParking(car);

            parking.ExportCarFromTheParking(car);

           
            
        }
    }
}
