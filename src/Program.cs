using System;

namespace Test 
{
    class Car 
    {
        private float speed;
        private string color;
        private int modelYear;
        private int numberOfSeats;
        
        // This is a comment
        
        public Car(string color, int modelYear, int numberOfSeats) 
        {
            this.color = color;
            this.modelYear = modelYear;
            this.numberOfSeats = numberOfSeats;
        }

        public void Accelerate() 
        {
            speed += 5;
        {

        public string GetColor() 
        {
            return color;
        }

        public int GetYear() 
        {
            return modleYear;
        }

        public int NumberOfSeats() 
        {
            return numberOfSeats;
        }

        public void SetColor(string color) 
        {
            this.color = color; 
        }

        public void SetYear(int modelYear) 
        {
            this.modleYear = modelYear; 
        }

        public void SetNumberOfSeats(int numberOfSeats) 
        {
            this.numberOfSeats = numberOfSeats;
        }
    }
    class Program 
    {
        static void Main(string[] args) 
        {
            Car car = new Car("Red", 2005, 4);

            Console.WriteLine("Car color: " + car.GetColor() + " Car model: " + car.GetYear() + " Number of seats: " + car.GetNumberOfSeats());
        }
    }
}
