using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Parking : Car
    {
        public double paymentForParking = 2.50;

        public bool VIPZone;
        public SortedSet<Car> cars = new SortedSet<Car>(); 

        
        public Parking()
        {
            
        }

        public Parking(double paymentParking, bool VIPZones, SortedSet<Car> _cars)
        {
            this.paymentForParking = paymentParking;
            this.VIPZone = VIPZones;
            this.cars = _cars;
        }

        private int index = 0;

        public void AddCarToTheParking(Car car)
        {
            cars.Add(car);
            index++;
            
        }
        public void ShowCarsOnTheParking()
        {
           
            base.Print();
           
            Console.WriteLine($" Totall payment for parking: {paymentForParking}");
        }

    }
}
