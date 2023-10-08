using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Parking 
    {
        private double paymentForParking = 2.50;

        private bool VIPZone;
        
        public Parking()
        {

        }

        public Parking(double paymentParking, bool VIPZones)
        {
            this.paymentForParking = paymentParking;
            this.VIPZone = VIPZones;          
        }

        public double PaymentForParking
        {
            get { return this.paymentForParking; }
            set { paymentForParking = value; }
        }
        
        public bool ViPZone
        {
            get { return this.VIPZone; }
            set { VIPZone = value; }
        }

        public void AddCarToTheParking(Car car)
        {
            car.Print();                    
        }

        public void ExportCarFromTheParking(Car car)
        {
            return;
        }
       

    }
}
