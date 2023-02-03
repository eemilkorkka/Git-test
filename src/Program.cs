using System;

namespace Test 
{
    class Car 
    {
        public string color;
        public int modelYear;
        public int numberOfSeats;
        
        // This is a comment
        
        public Car(string color, int modelYear, int numberOfSeats) 
        {
            this.color = color;
            this.modelYear = modelYear;
            this.numberOfSeats = numberOfSeats;
        }
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            Car car = new Car("Red", 2005, 4);

            Console.WriteLine("Car color: " + car.color + " Car model: " + car.modelYear + " Number of seats: " + car.numberOfSeats);
        }
    }
}
