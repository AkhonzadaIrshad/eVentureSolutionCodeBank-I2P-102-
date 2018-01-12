using System;

namespace ConsoleApp
{
    class Bike
    {
        //Access Specifiers
        //Public 
        //Inside of the Class and Outside of Class Can be Accessable 


        private int wheels;
        private string company;
        private double price;
        private string model;


        public void SetCompany(string companyName)
        {
            if (companyName!=""&&companyName.Length<20)
            {
                company = companyName;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }



        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                
            }
        }
        //public void SetPrice(double Price)
        //{
        //    price = Price;
        //}

        //public double GetPrice()
        //{
        //    return price;
        //}


        public int Wheels
        {
            get
            {
                return wheels;
                
            }
            set
            {

                if (value > 0 && value <= 3)
                {
                    wheels = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }


        //public void SetWheels(int Wheels)
        //{

        //    if (Wheels > 0 && Wheels <= 3)
        //    {
        //        wheels = Wheels;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Input");
        //    }
        //}

        //public int GetWheels()
        //{
        //    return wheels;
        //}





        public void SetModel(string Model)
        {
            model = Model;
        }
       
        public void Display()
        {
            Console.WriteLine("Bike Information\n" +
                              $"Company Name : {company}\n" +
                              $"Wheels       : {wheels}\n" +
                              $"Price        : {price}\n" +
                              $"Model        : {model}");
        }


        //Constructor
        //Method
        //Auto Call

        public Bike()
        {
            company = "EMPTY";
            price = 00;
            model = "EMPTY";
            wheels = 2;

        }




    }
}
