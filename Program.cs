using System;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars Exercise!");

            Mercedes mer = new Mercedes();
            mer.DisplayInfo();
        }
    }

    class Car
    {
        private decimal price;
        public string color;
        protected int maxSpeed;

        protected decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Inside Car Display Info");
            price = 10000;
            color = "Black";
            maxSpeed = 300;

            Console.WriteLine($"Default Values Price = ${price} Color = {color} MaxSpeed = {maxSpeed}");

            
        }
    }

    class Mercedes : Car
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.color = "Blue";
            base.maxSpeed = 350;
            base.Price = 15000;

            Console.WriteLine($"Override Values Price = ${base.Price} Color = {color} MaxSpeed = {maxSpeed}");

        }
    }
}
