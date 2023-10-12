using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Parking
    {
        private int id;
        private string nameOfParking;
        private string address;
        private int capacity;
        private List<Car> car;

        private int capacityOfParkingPlaces; 

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
        public Parking(int _id, string _nameOfParking, string _address, int _сapacity)
        { 
            this.id = _id;
            this.nameOfParking = _nameOfParking;
            this.address = _address;
            this.capacity = _сapacity;
            
            car = new List<Car>(_сapacity);        
        }

        /// <summary>
        /// The "Id" 
        /// </summary>
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
            
        /// <summary>
        /// The name of parking
        /// </summary>
        public string NameOfParking
        {
            get { return nameOfParking; }
            set { this.nameOfParking = value; }
        }

        /// <summary>
        /// The address of parking 
        /// </summary>
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }

        /// <summary>
        /// The parking capacity
        /// </summary>
        public int Capacity
        {
            get { return capacity; }
            set { this.capacity = value; }
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
            if(this.car.Count < capacity)
            {
                this.car.Add(_car);
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
        public void ExportCarFromTheParking(Car _car)
        {
            if(this.car.Count > 0)
            {
                if (this.car.Contains(_car))
                {
                    this.car.Remove(_car);
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
            int available = CalculatingFreePlaces(capacity, car);
            Console.WriteLine($"The places are free - { available}");
        }

        /// <summary>
        /// Method is counting how many places at the parking are free
        /// </summary>
        /// <param name="capacity"></param>
        /// <param name="car"></param>
        /// <returns></returns>
        public int CalculatingFreePlaces(int capacity, List <Car> car)
        {
            int totalCapacity = capacity;
            int totalCars = car.Count; 

            int availableSpaces = totalCapacity - totalCars;

            return availableSpaces;
        }

       

    }
}
