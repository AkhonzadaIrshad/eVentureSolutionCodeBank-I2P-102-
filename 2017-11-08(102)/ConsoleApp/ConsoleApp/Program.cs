using System;

namespace ConsoleApp
{
    class Program
    {



        static int GenerateRandomNumber()
        {

            Random number = new Random();
            int value = number.Next(1, 50);
            return value;

        }


        static int GetUserInput()
        {
            int number;
            Console.WriteLine("Guess My Number Between 1-50");
            number = Convert.ToInt32(Console.ReadLine());
            return number;
        }



        static void PlayGame(int userNumber, int randomNumber)
        {

            //  int number=userNumber;
            if (userNumber == randomNumber)
            {
                Console.WriteLine("Success");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Your Number is Less Than Random Number Try Again");
            }
            else
            {
                Console.WriteLine("Your Number is Greater Than Random Number Try Again");
            }
        }




        static void Main(string[] args)
        {
            int randomNumber = GenerateRandomNumber();
            int userInput;
            do
            {
                userInput = GetUserInput();

                PlayGame(userInput, randomNumber);

            } while (userInput != randomNumber);













                Console.ReadKey();
        }
    }
}
