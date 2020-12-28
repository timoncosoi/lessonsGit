using System;

namespace dotnetDelegate
{
    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.Start();
            car.RegistetTooFast(TooFast);
            car.RegistetTooSlow(TooSlow);
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
        }
        private static void TooFast(){
            Console.WriteLine("Wooo!! Please stop Car!");
            car.Slowing();
            car.Slowing();
            car.Slowing();
            //car.Stop();
        }
        private static void TooSlow(){
            Console.WriteLine("Now your car is stop");
        }
    }
}
