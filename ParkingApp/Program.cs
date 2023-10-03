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

            car.brand = "BMW";
            car.model = "M5";
            car.color = "Black";
            car.number = "BH 1234 HE";
            car.timeWhichCarCame = "11:00";
            car.timeWhichCarLeft = "At the parking";

            parking.AddCarToTheParking(car);
            parking.ShowCarsOnTheParking();
           
            Car car1 = new Car();
            car1.brand = "Toyota";
            car1.model = "Hiace";
            car1.color = "White";
            car1.number = "BH 6723 OA";
            car1.timeWhichCarCame = "12:37";
            car1.timeWhichCarLeft = "14:20";


            
            
        }
    }
}
