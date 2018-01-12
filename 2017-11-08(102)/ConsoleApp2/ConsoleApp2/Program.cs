using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Fan //Title Case
    {
        //Data Members - Fields
        //Methods 
        //Simple
        //Special
        //Properties
        //Constructors

        //Fields
        public int wings;//Camel Case
        public string color;
        public string type;
        public double price;
        public string name;

        public void Display()
        {
            Console.WriteLine("_____Welcome To FAN Factory_______");
            Console.WriteLine($"Name  {name } \n" +
                              $"Type  {type } \n" +
                              $"Wings {wings} \n" +
                              $"Price {price} \n" +
                              $"Color {color} \n" +
                              "_______________________________");
        }




    }

    //class EVS
    //{

    //}


    class Program
    {
        static void Main(string[] args)
        {
            //Object Declaration
            Fan firstFan;
            //Object Initialization 
            firstFan = new Fan();

            firstFan.color = "White";
            firstFan.price = 1000.00;
            firstFan.type  = "Type Two";
            firstFan.wings = 3;
            firstFan.name  = "Pak Fan";

            firstFan.Display();
            


            Fan secondFan=new Fan();
            secondFan.color = "Black";
            secondFan.price = 3000.00;
            secondFan.type = "Type Three";
            secondFan.wings = 5;
            secondFan.name = "EVS Fan";
            secondFan.Display();

            //Console.WriteLine("_____Welcome To FAN Factory_______");
            //Console.WriteLine($"Name  {secondFan.name } \n" +
            //                  $"Type  {secondFan.type } \n" +
            //                  $"Wings {secondFan.wings} \n" +
            //                  $"Price {secondFan.price} \n" +
            //                  $"Color {secondFan.color} \n" +
            //                  "_______________________________");






            //EVS evs =new EVS();



            Console.ReadKey();


        }

    }

    
}
