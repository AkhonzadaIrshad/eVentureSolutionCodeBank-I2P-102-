using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Method Signature:
        //return Type 
        //Name
        //Number of Parameters
        //Sequence of Parameters
        //Data Type of Parameters





        //static void MethodName()
        //{
        //    Console.WriteLine("This is a Method From C#");
        //}

        //static void SecondMethod(string language)
        //{

        //    Console.WriteLine($"This is a Method From {language}");

        //}


        static int InputMethod()
        {
            int number;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

       

        static int AddMethod(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }



        static void PrintMethod(int number)
        {
            Console.WriteLine($"The Number is {number}");
        }


        static void Main(string[] args)
        {
            //What Is a Method?
            //Why Method?
            //How A Method ?

            //MethodName();

            //string name = "C#";

            //SecondMethod(name);

            //name = "PHP";
            //SecondMethod(name);


            int one, two, result;

            one = InputMethod();
            two = InputMethod();
            result = AddMethod(one, two);
            PrintMethod(result);



            // PrintMethod(AddMethod(InputMethod(),InputMethod()));





            Console.ReadKey();


        }
      
    }
}
