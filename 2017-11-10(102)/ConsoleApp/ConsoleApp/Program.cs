using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Classes
    class Fan
    {
        //Fields

        //Access Specifiers
        //Public:
        //Can be Accessable Inside or Outside of the Class
        //Private:
        //Can be Accessable Inside but Not Outside of the Class

        //Protected




        //All Fields Must be Private

        private int wings;
        private string company;
        private double price;


        //Properties

        public int Wings
        {
            set
            {
                if (value > 0 && value <= 4)
                {
                    wings = value;
                }
                else
                {
                    Console.WriteLine("Invalid Number of Wings");
                }
                
            }
            get
            {
                return wings;
                
            }
            
        }
      



        //public void SetWings(int wingsValue)
        //{
        //    if (wingsValue > 0 && wingsValue <= 4)
        //    {
        //        wings = wingsValue;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Number of Wings");
        //    }

        //}
        //public int GetWings()
        //{
        //    return wings;
        //}


        public void SetCompany(string companyValue)
        {

            if (companyValue.Length < 20)
            {
                company = companyValue;
            }
            else
            {
                Console.WriteLine("Invalid Company Name ");
            }



        }
        public string GetCompany()
        {
            return company;
        }


        public void SetPrice(double priceValue)
        {
            if (priceValue > 0)
            {
                price = priceValue;
            }
            else
            {
                Console.WriteLine("Price must be greater than zero");
            }

        }
        public double GetPrice()
        {
            return price;
        }



        //Methods
        public void Display()
        {
            Console.WriteLine($"Wings   : {wings  }\n" +
                              $"Company : {company}\n" +
                              $"Price   : {price  }\n");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            Fan first = new Fan();

            int wings;
            string companyName;
            double price;


            Console.WriteLine("Welcome To FAN Factory");
            Console.WriteLine("Enter Fan Wings");
            wings = Convert.ToInt32(Console.ReadLine());

            first.Wings=wings;


            Console.WriteLine("Enter Fan Company");
            companyName = Console.ReadLine();

            first.SetCompany(companyName);


            Console.WriteLine("Enter Fan Price");
            price = Convert.ToDouble(Console.ReadLine());

            first.SetPrice(price);

            Console.Clear();

            wings = first.Wings;
            companyName = first.GetCompany();
            price = first.GetPrice();

            Console.WriteLine(wings);
            Console.WriteLine(companyName);
            Console.WriteLine(price);

            //first.Display();

            Console.ReadKey();

        }
    }
}
