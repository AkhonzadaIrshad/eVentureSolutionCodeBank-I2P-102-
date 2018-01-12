using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers=new int[10];
            int sumOfNumbers = 0;
            int min = 0;
            int max = 0;


            for (int index = 0; index < numbers.Length; index++)
            {

                Console.WriteLine($"Enter Number {index+1}");
                numbers[index] = Convert.ToInt32(Console.ReadLine());
                sumOfNumbers =sumOfNumbers+ numbers[index];
                if (index == 0)
                {
                    min = numbers[index];
                }
                if (numbers[index]<min)
                {
                    min = numbers[index];
                }
                if (numbers[index]>max)
                {
                    max = numbers[index];
                }

            }

            Console.WriteLine($"Sum of {numbers.Length} is {sumOfNumbers} \n" +
                              $"______________________________\n" +
                              $"Minimum Number is {min}\n" +
                              $"______________________________\n" +
                              $"Maxumum Numebr is {max}");



            Console.ReadKey();


        }
    }
}
