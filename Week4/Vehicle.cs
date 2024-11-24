using System;
namespace Week4
{
	struct Vehicle: IDrivable {
		public string Name { get; }
		public Duplicate.Vehicle VehicleType { get; }



        public  Vehicle (string name, Duplicate.Vehicle vehicleType)
        {
            Name = name;
            VehicleType = vehicleType;
        }

        #region
        public void Drive()
        {
            Console.WriteLine($"{Name}, a {VehicleType}, is driving on the track!");

        }
        #endregion
    }
}


