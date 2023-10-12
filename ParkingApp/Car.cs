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

        private Color _color;

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Car()
        {

        }

        /// <summary>
        /// Constructor for work with parameters of car
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="color"></param>
        /// <param name="number"></param>
        /// <param name="timeWhichCarCame"></param>
        /// <param name="timeWhichCarLeft"></param>
        public Car(string brand, string model, string color, string number, string timeWhichCarCame, string timeWhichCarLeft)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.number = number;
            this.timeWhichCarCame = timeWhichCarCame;
            this.timeWhichCarLeft = timeWhichCarLeft;
        }

        /// <summary>
        /// The brand of car
        /// </summary>
        public string Brand
        {
            get { return this.brand; }
            set { brand = value; }
        }

        /// <summary>
        /// The model of car
        /// </summary>
        public string Model
        {
            get { return this.brand; }
            set { model = value; }
        }

        /// <summary>
        /// The car`s color
        /// </summary>
        public string Color
        {
            get { return this.color; }
            set { color = value; }
        }

        /// <summary>
        /// The car number
        /// </summary>
        public string Number
        {
            get { return this.brand; }
            set { model = value; }
        }

        /// <summary>
        /// Time which car is came at the parking
        /// </summary>
        public string TimeWhichCarCame
        {
            get { return this.timeWhichCarCame; }
            set { timeWhichCarCame = value; }
        }

        /// <summary>
        /// Time which car is left the parking
        /// </summary>
        public string TimeWhichCarLeft
        {
            get { return this.timeWhichCarLeft; }
            set { timeWhichCarLeft = value; }
        }

        /// <summary>
        /// Change color at the car
        /// </summary>
        /// <param name="col"></param>
        public void ChangeColor(Color col)
        {
            this.color = col.ToString();
        }

        /// <summary>
        /// The method is showing the all information about car
        /// </summary>
        public void Print()
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
