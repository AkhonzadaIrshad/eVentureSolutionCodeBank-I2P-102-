using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike firstBike;
            firstBike = new Bike();

            Console.WriteLine("Enter Company Name");
            string company = Console.ReadLine();
            firstBike.SetCompany(company);
            Console.WriteLine("Enter Wheels");
            int wheels = Convert.ToInt32(Console.ReadLine());
            firstBike.Wheels=wheels;
            Console.WriteLine("Enter Model");
            string model = Console.ReadLine();
            firstBike.SetModel(model);
            Console.WriteLine("Enter Price");
            double price = Convert.ToDouble(Console.ReadLine());
            
            firstBike.Price=price;
            
            Console.WriteLine("First Bike");
            firstBike.Display();


            //Bike secondBike = new Bike();


            //Console.WriteLine("Enter Company Name");
            //company = Console.ReadLine();
            //secondBike.SetCompany(company);
            //Console.WriteLine("Enter Wheels");
            //wheels = Convert.ToInt32(Console.ReadLine());
            //secondBike.Wheels=wheels;
            //Console.WriteLine("Enter Model");
            //model = Console.ReadLine();
            //secondBike.SetModel(model);
            //Console.WriteLine("Enter Price");
            //price = Convert.ToDouble(Console.ReadLine());
            //secondBike.Price=price;


            //Console.WriteLine("Second Bike");


            //secondBike.Display();




            Console.ReadKey();






        }
    }
}
