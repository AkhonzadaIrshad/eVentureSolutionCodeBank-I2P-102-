using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] Names=new string[1];

            //Console.WriteLine("Please Enter Your Name ");
            //Names[0] = Console.ReadLine();

            //for (int start = 0; start < Names.Length; start++)
            //{

            //    Console.WriteLine("Enter Your Name");
            //    Names[start] = Console.ReadLine();

            //}





            //int Number = 0;
            //int from = 0;
            //int to = 0;
            //Console.WriteLine("Enter A Number to Print its Table");
            //Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter Start Of the Table ");
            //from = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter End Of the Table ");
            //to = Convert.ToInt32(Console.ReadLine());



            //2 x 1 = 2


            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine(Number + " x " + i + " = " + Number * i);


            //    Console.WriteLine($"{Number} x {i} = {Number*i}");
            //}


            //for (int i = from; i <=to; i++)
            //{
            //    //Console.WriteLine(Number + " x " + i + " = " + Number * i);


            //    Console.WriteLine($"{Number} x {i} = {Number * i}");
            //}



            //While


            string name;
            string userInput;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();



            //while (userInput.ToLower() != "ok")
            //{
            //    Console.WriteLine($"Hello {name}");
            //    Console.WriteLine("Type OK to exit");
            //    userInput = Console.ReadLine();//ok
            //}


            do
            {
                Console.WriteLine($"Hello {name}");
                Console.WriteLine("Type OK to exit");
                userInput = Console.ReadLine();//ok



            } while (userInput.ToLower() != "ok");











            Console.ReadKey();



        }
    }
}
