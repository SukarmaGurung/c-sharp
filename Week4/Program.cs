// See https://aka.ms/new-console-template for more information
using System;

namespace Week4
{
    public class Program
    {
        public static void Main()
        {
            //Laptop dell = new Laptop("Dell");
            // dell.DisplayDetails();
            // Laptop lenovo = new Laptop("lenovo");
            // dell.DisplayDetails();
            // lenovo.DisplayDetails();
              
            Vehicle vehicle = new Vehicle("Ferrari", Duplicate.Vehicle.Car);
            vehicle.Drive();  //--------------
                              //vehicle.PlayRadio();

            //IDrivable vehicleI = new IDrivable();
            IDrivable vehicleI = vehicle;
            vehicleI.PlayRadio();
            vehicleI.Drive(); //--------------




        }
    }
}