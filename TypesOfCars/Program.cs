using System;

namespace TypesOfCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Kia";
            myCar.Model = "Optima";
            myCar.Year = 2016;

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}
