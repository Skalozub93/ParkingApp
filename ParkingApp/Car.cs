using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Car
    {
        private string brand;
        private string model;
        private string color;
        private string number;
        private string timeWhichCarCame;
        private string timeWhichCarLeft;

        public Car()
        {
        }

        public Car(string brand, string model, string color, string number, string timeWhichCarCame, string timeWhichCarLeft)
        {
            this.brand=brand;
            this.model=model;
            this.color=color;
            this.number=number;
            this.timeWhichCarCame=timeWhichCarCame;
            this.timeWhichCarLeft=timeWhichCarLeft;
        }

        public string Brand
        {
            get { return this.brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return this.brand; }
            set { model = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { color = value; }
        }

        public string Number
        {
            get { return this.brand; }
            set { model = value; }
        }

        public string TimeWhichCarCame
        {
            get { return this.timeWhichCarCame; }
            set { timeWhichCarCame = value; }
        }

        public string TimeWhichCarLeft
        {
            get { return this.timeWhichCarLeft; }
            set { timeWhichCarLeft = value; }
        }

        public  void Print()
        {
            Console.WriteLine($" Brand: {brand}");
            Console.WriteLine($" Model: {model}");
            Console.WriteLine($" Color: {color}");
            Console.WriteLine($" Car Number: {number}");
            Console.WriteLine($" When car is came to the parking: {timeWhichCarCame}");
            Console.WriteLine($" Time in which car is left the parking: {timeWhichCarLeft}");
            Console.WriteLine();
        }
    }
}
