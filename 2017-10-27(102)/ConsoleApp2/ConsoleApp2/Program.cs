using System;
namespace ConsoleApp2
{
    class Program
    {


       static  void OurFirstMethod()
        {

            Console.WriteLine("Hello From Our First Method ");

        }



        static void SubtractMethod()
        {
            int one, two, result;
            Console.WriteLine("Enter Number One");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Two");
            two = Convert.ToInt32(Console.ReadLine());
            result = one - two;
            Console.WriteLine($"Result : {result}");
        }

        static void AddMethod()
        {
            int one, two,result;
            Console.WriteLine("Enter Number One");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number Two");
            two = Convert.ToInt32(Console.ReadLine());
            result = one + two;
            Console.WriteLine($"Result : {result}");
        }




        static void PrintSomething(string AnyText)//Parameters
        {
            Console.WriteLine(AnyText);
        }




        static void Main(string[] args)
        {


            string Text = "EVS LAHORE";

            PrintSomething(Text);//Argument





           // OurFirstMethod();

            //int userInput;
            //Console.WriteLine("Press 1 to Add and 2 to Subtract");
            //userInput = Convert.ToInt32(Console.ReadLine());
            //switch (userInput)
            //{
            //    case 1:
            //    {
            //        AddMethod();
            //            break;
            //    }
            //    case 2:
            //    {
            //        SubtractMethod();
            //            break;
            //    }
            //    default:
            //    {
            //        Console.WriteLine("Your Entered something wrong");
            //            break;
            //    }
            //}

           


            Console.ReadKey();

        }
    }
}
