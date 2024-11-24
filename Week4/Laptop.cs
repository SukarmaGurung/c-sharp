using System;
namespace Week4
{
	public class Laptop
	{
		public const int MaxBattery = 100; // tei dine ho value const ma
		public static int TotalProduced;
		public readonly string SerialNumber;
		public string BrandName;
		public static List<string> CreatedLaptops;
		public Laptop(string brandName)
		{
			BrandName = brandName;
			TotalProduced += 1;
			//can you change Maxbattery to 999
			//globally unique identifier
			Guid id = Guid.NewGuid(); //using inbuilt class
			SerialNumber = id.ToString();
			List<string> CreatedLaptops = new List<string>();
			CreatedLaptops.Add(SerialNumber);

		}
		public void DisplayDetails()
        {
            Console.WriteLine("-------- Detail --------");
            Console.WriteLine("Brand name: " + BrandName);
            Console.WriteLine("Serial number: " + SerialNumber + "\n");
            Console.WriteLine("Total laptops: " + TotalProduced);
            Console.WriteLine("------------------------\n");
        }

        #region Method to change serialNumber
        //public void ChangeSerialNumber(string newSerialNumber)
        //{
        //    Guid id = Guid.NewGuid(); // using in-built class
        //    SerialNumber = id.ToString();
        //}
        #endregion
    }
}

