using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("THis is Printing in C#");

            /* Console.WriteLine("First Line");
             Console.WriteLine("Second Line");
             Console.WriteLine("Third Line");
             Console.WriteLine("Fourth Line");
             */

            //Variables
            //int firstVarible;// Declaration Statement
            //firstVarible = 1;//Initialization Statement

            //int secondVariable = 2;

            //int RollNumber = 123;


            //float fees = 100.00f;


            //Console.Write("Student Roll Number");
            //Console.WriteLine(RollNumber);
            //Console.Write("Student Fees");
            //Console.WriteLine(fees);



            //int One=12;
            //int Two=11;
            //int Three=One/Two;




            //Data Types In C#

            //Numeric
            ////Non Precise
            //short _short = 123;
            //int _int = 123;
            //long _long = 123;

            ////Precise
            //float _float = 123.00f;
            //double _double = 123.00;

            ////Textual
            //char _char = 'A';

            //string _string = "This is First String Variable";


            //int number=111;

            //Console.WriteLine("Please Enter A Number ");
            //number = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Your Number Was : ");
            //Console.WriteLine(number);


            int rollNumber;
            double fees, marks;
            string name;
            char grade;

            Console.WriteLine("-- Welcome To EVS Lahore --");
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Roll Number");
            rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Fees");
            fees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Your Marks");
            marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Your Grade");
            grade = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n\n");
            Console.WriteLine("****Your Details*****");
            Console.Write("Name : ");
            Console.WriteLine(name);
            Console.Write("Roll Number : ");
            Console.WriteLine(rollNumber);
            Console.Write("Fees : ");
            Console.WriteLine(fees);
            Console.Write("Marks : ");
            Console.WriteLine(marks);
            Console.Write("Grade : ");
            Console.WriteLine(grade);








            Console.ReadKey();

        }
    }
}
