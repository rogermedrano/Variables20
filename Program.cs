using System;

namespace Variables20
{
    class Program
    {
        static void Main(string[] args)
        {
            string makeOfFirstCar = "GMC";
            int yearOfCar = 2011;
            char firstLetterOfModel = 'A';
            bool lease = true;
            double carPayment = 150.00;
            decimal engineSize = 4.7M;

            Console.WriteLine($"My first car was a {yearOfCar} {makeOfFirstCar}. I paid {carPayment} a friggin month for it.");

        }
    }
}
