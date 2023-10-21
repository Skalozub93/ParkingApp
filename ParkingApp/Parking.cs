using ParkingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;





namespace ParkingApp
{


    class Parking : IDisposable
    {

        private int _id;
        private string _nameOfParking;
        private string _address;
        private int _capacity;
        private List<Car> _car;

        private int capacityOfParkingPlaces;
        private bool disposed;
     

        /// <summary>
        /// Constructor without parameters 
        /// </summary>
        public Parking()
        {

        }

        /// <summary>
        /// Counstructor with parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameOfParking"></param>
        /// <param name="address"></param>
        /// <param name="capacity"></param>
        /// <param name="_car"></param>
        public Parking(int id, string nameOfParking, string address, int сapacity)
        { 
            this._id = id;
            this._nameOfParking = nameOfParking;
            this._address = address;
            this._capacity = сapacity;           
            _car = new List<Car>(сapacity);        
        }

        /// <summary>
        /// C-ctor with 3 parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameOfParking"></param>
        /// <param name="address"></param>
        public Parking(int id, string nameOfParking, string address)
        {
            _id = id;
            nameOfParking = "A big car park";
            _address = address;
        }

        /// <summary>
        /// C-ctor with 2 parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="capacity"></param>
        public Parking(int id, int capacity)
        {
            _id = id;
            _capacity = capacity;
        }

        /// <summary>
        /// The "Id" 
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { this._id = value; }
        }
            
        /// <summary>
        /// The name of parking
        /// </summary>
        public string NameOfParking
        {
            get { return _nameOfParking; }
            set { this._nameOfParking = value; }
        }

        /// <summary>
        /// The address of parking 
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { this._address = value; }
        }

        /// <summary>
        /// The parking capacity
        /// </summary>
        public int Capacity
        {
            get { return _capacity; }
            set { this._capacity = value; }
        }

        /// <summary>
        /// Parking capacity
        /// </summary>
        public int CapacityOfParkingPlaces
        {
            get { return capacityOfParkingPlaces; }
            set { this.capacityOfParkingPlaces = value; }
        }

        /// <summary>
        /// Method, which checking for parking place fullness, if the place is free - car automaically adding
        /// </summary>
        /// <param name="car"></param>
        /// <param name="id"></param>
        public void AddCarToTheParking(Car _car)
        {
            if(this._car.Count < _capacity)
            {
                this._car.Add(_car);
                Console.WriteLine("Car was added to the parking!");
            }
            else
            {
                Console.WriteLine("The parking place is busy!");
            }
        }

        /// <summary>
        /// The overloading method <AddCarToTheParking> with 2 parameters
        /// </summary>
        /// <param name="car"></param>
        /// <param name="id"></param>
        public void AddCarToTheParking(Car car, int id)
        {
            id++;
            if (this._car.Count < _capacity)
            {
                this._car.Add(car);
                Console.WriteLine("Car was added to the parking!");
            }
            else
            {
                Console.WriteLine("The parking place is busy!");
            }
        }

        /// <summary>
        /// Method, which checking for parking place emptity, if the place is busy - car automaically removing
        /// </summary>
        /// <param name="car"></param>
        public void ExportCarFromTheParking(Car car)
        { 
            if(this._car.Count > 0)
            {
                if (this._car.Contains(car))
                {
                    this._car.Remove(car);
                    Console.WriteLine("Car was removed from the parking!");
                }
                else
                {
                    Console.WriteLine("The specified car there is no at the parking!");
                }
            }
            else
            {
                Console.WriteLine("The parking place is free!");
            }
            
        }

        /// <summary>
        /// The overloading method <ExportCarFromTheParking> with 2 parameters
        /// </summary>
        /// <param name="car"></param>
        /// <param name="id"></param>
        public void ExportCarFromTheParking(Car car, int id)
        {
            id--;
            if (this._car.Count > 0)
            {
                if (this._car.Contains(car))
                {
                    this._car.Remove(car);
                    Console.WriteLine("Car was removed from the parking!");
                }
                else
                {
                    Console.WriteLine("The specified car there is no at the parking!");
                }
            }
            else
            {
                Console.WriteLine("The parking place is free!");
            }
        }

        /// <summary>
        /// Information about parking place
        /// </summary>
        public void GetStateMessage()
        {
            int available = CalculatingFreePlaces();
            Console.WriteLine($"The places are free - { available}");
        }

        /// <summary>
        /// Method is counting how many places at the parking are free
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        public int CalculatingFreePlaces()
        {        
            return Capacity - _car.Count;
        }

        /// <summary>
        /// Method for cleaning all cars from the parking, when it necessary 
        /// </summary>
        public void Dispose()
        {
            foreach(Car car in _car)
            {
                _car.Clear();
            }
            Console.WriteLine("Cars have been left the parking!");
        }
    }
}
