using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int rollNumber;
            //string name;
            //double fees;

            //Console.WriteLine("Enter Name : ");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter Roll Number : ");
            //rollNumber =Convert.ToInt32(Console.ReadLine());

            ////Conditional Structure
            //if (rollNumber > 0)
            //{
            //    //Console.WriteLine("Everything is good :)");
            //    Console.WriteLine("Enter Fees : ");
            //    fees = Convert.ToDouble(Console.ReadLine());


            //}
            //else
            //{

            //    Console.WriteLine("Your Roll Number was Invalid :(");
            //}




            //ctrl+k,ctrl+c







            //int Number=2;


            //if (Number==1)
            //{
            //    Console.WriteLine("Number is One");
            //}
            //else if (Number==2)
            //{
            //    Console.WriteLine("Number is Two");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Invalid");
            //}


            //int Number = 1;
            //if (Number>0)
            //{
            //    Console.WriteLine("Number is Positive");
            //}
            //if (Number==1)
            //{
            //    Console.WriteLine("Number is One ");
            //}
            //else if (Number==2)
            //{
            //    Console.WriteLine("Number is Two");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Neither One Nor Two");
            //}



            //double numberOne, numberTwo;
            //char function;//+,-,/,*

            //Console.WriteLine("-- Welcome to Our First Calculator --");
            //Console.WriteLine("Enter Number One");
            //numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number Two");
            //numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Operations (+,-,*,/) your choice ?");
            //function = Convert.ToChar(Console.ReadLine());


            //switch (function)
            //{
            //    case '+':
            //        {
            //            Console.Write("Answer :");
            //            Console.WriteLine(numberOne + numberTwo);
            //            break;
            //        }
            //    case '-':
            //        {
            //            Console.Write("Answer :");
            //            Console.WriteLine(numberOne - numberTwo);
            //            break;
            //        }
            //    case '*':
            //        {
            //            Console.Write("Answer :");
            //            Console.WriteLine(numberOne * numberTwo);
            //            break;
            //        }
            //    case '/':
            //        {
            //            Console.Write("Answer :");
            //            Console.WriteLine(numberOne / numberTwo);
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Math Error");
            //            break;
            //        }


            //}











            // if (function=='+')
            // {
            //     Console.Write("Answer :");
            //     Console.WriteLine(numberOne + numberTwo);
            // }
            // else if (function == '-')
            // {
            //     Console.Write("Answer :");

            //     Console.WriteLine(numberOne+numberTwo);
            // }
            //else if (function == '*')
            // {
            //     Console.Write("Answer :");
            //     Console.WriteLine(numberOne * numberTwo);
            // }
            // else if (function == '/')
            // {
            //     Console.Write("Answer :");
            //     Console.WriteLine(numberOne / numberTwo);
            // }
            // else
            // {
            //     Console.WriteLine("Math Error");
            // }



            int Marks;
            Console.WriteLine( "Enter your Marks");
            Marks=Convert.ToInt32(Console.ReadLine());
            if ((Marks >= 90) || (Marks < 100))
            {
                Console.WriteLine("Grade : A+");
            }
            else if((Marks>=80)&&(Marks<90))
            {
                Console.WriteLine("Grade : A");
            }
            else if ((Marks >= 70) && (Marks < 80))
            {
                Console.WriteLine("Grade : B+");
            }
            else if (Marks>=50)
            {
                Console.WriteLine("Grade : C");
            }
            else
            {
                Console.WriteLine("Grade : F :(");
            }



            //Operators
            //Math Operators
            //+,-,*,/,%,^

            //Comparison Operator
            //==, > , < , >=, <= , !=

            //Assignment Operator
            //=

            //Logical Operators
            //&&
            //||



            Console.ReadKey();



        }
    }
}
