using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public string number;
        public string timeWhichCarCame;
        public string timeWhichCarLeft;

        
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
