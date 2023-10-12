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
            Color color = new Color();
                       
            car.Brand = "Toyota";
            car.Model = "Hilux";
            car.Number = "BH 1234 EA";
            car.Color = "Black";
            car.TimeWhichCarCame = "12:23";
            car.TimeWhichCarLeft = "17:12";
            color.Opacity = 50;
            color.Red = 121;

            Parking parking = new Parking(1, "Odesa Parking", "Zhukowskogo 15", 50);


            //parking.AddCarToTheParking(car);
            parking.GetStateMessage();
            
            Car car2 = new Car();
            car2.Brand = "BMW";
            car2.Model = "X5";
            car2.Number = "BH 2145 UA";
            car2.Color = "Red";
            car2.TimeWhichCarCame = "13:00";
            car2.TimeWhichCarLeft = "-";

            parking.AddCarToTheParking(car2);
            parking.GetStateMessage();

            parking.ExportCarFromTheParking(car);
            parking.GetStateMessage();













        }
    }
}
