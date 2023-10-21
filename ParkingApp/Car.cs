using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private string _number;
        private DateTime _timeWhichCarCame;
        private DateTime _timeWhichCarLeft;

        private Color _colorObject;

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
        public Car(string brand, string model, string color, string number, DateTime timeWhichCarCame, DateTime timeWhichCarLeft)
        {
            this._brand = brand;
            this._model = model;
            this._color = color;
            this._number = number;
            this._timeWhichCarCame = timeWhichCarCame;
            this._timeWhichCarLeft = timeWhichCarLeft;
        }

        /// <summary>
        /// C-ctor with 3 parameters
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="number"></param>
        public Car(string brand, string model, string number)
        {
            _brand = brand;
            _model = model;
            _color = default;
            _number = number;          
        }

        /// <summary>
        /// C-ctor with 5 parameters
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="number"></param>
        /// <param name="timeWhichCarCame"></param>
        /// <param name="timeWhichCarLeft"></param>
        public Car(string brand, string model, string number, DateTime timeWhichCarCame, DateTime timeWhichCarLeft)
        {
            _brand = brand;
            _model = model;
            _color = default;
            _number = number;
            _timeWhichCarCame = timeWhichCarCame;
            _timeWhichCarLeft = timeWhichCarLeft;
        }

        

        /// <summary>
        /// The brand of car
        /// </summary>
        public string Brand
        {
            get { return this._brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// The model of car
        /// </summary>
        public string Model
        {
            get { return this._brand; }
            set { _model = value; }
        }

        /// <summary>
        /// The car`s color
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { _color = value; }
        }

        /// <summary>
        /// The car number
        /// </summary>
        public string Number
        {
            get { return this._brand; }
            set { _model = value; }
        }

        /// <summary>
        /// Time which car is came at the parking
        /// </summary>
        public DateTime TimeWhichCarCame
        {
            get { return this._timeWhichCarCame; }
            set { _timeWhichCarCame = value; }
        }

        /// <summary>
        /// Time which car is left the parking
        /// </summary>
        public DateTime TimeWhichCarLeft
        {
            get { return this._timeWhichCarLeft; }
            set { _timeWhichCarLeft = value; }
        }

        /// <summary>
        /// Change color at the car
        /// </summary>
        /// <param name="col"></param>
        public void ChangeColor(Color col)
        {
            this._color = col.ToString();
        }

        /// <summary>
        /// The method is showing the all information about car
        /// </summary>
        public void Print()
        {
            Console.WriteLine($" Brand: {_brand}");
            Console.WriteLine($" Model: {_model}");
            Console.WriteLine($" Color: {_color}");
            Console.WriteLine($" Car Number: {_number}");
            Console.WriteLine($" When car is came to the parking: {_timeWhichCarCame}");
            Console.WriteLine($" Time in which car is left the parking: {_timeWhichCarLeft}");
            Console.WriteLine();
        }
    }
}
