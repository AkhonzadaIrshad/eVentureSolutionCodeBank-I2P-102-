
using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Marks
            //Total Marks
            //Average
            //Persentage
            //Division

            double math, physics, chemistry, urdu, totalMarks;
            double average, percentage;
            string division;
            Console.WriteLine("Enter Your Mark ");
            Console.WriteLine("Marks of Math");
            math = Convert.ToDouble(Console.ReadLine());
            totalMarks = math;//50
            Console.WriteLine("Marks of Physics");
            physics = Convert.ToDouble(Console.ReadLine());
            totalMarks = totalMarks + physics;
            Console.WriteLine("Marks of Chemistry");
            chemistry = Convert.ToDouble(Console.ReadLine());
            totalMarks = totalMarks + chemistry;
            Console.WriteLine("Marks of Urdu");
            urdu = Convert.ToDouble(Console.ReadLine());
            totalMarks += urdu;





            //Concatenation 

            //string first = "First", Second = "Second";

            //string third = first + Second;
            percentage = totalMarks / 400 * 100;
            average = totalMarks / 4;

            if (percentage >= 90)
            {
                division = "First";
            }
            else if (percentage < 90 && percentage >= 80)
            {
                division = "Second";
            }
            else if (percentage < 80 && percentage >= 70)
            {
                division = "Third";
            }
            else
            {
                division = "Fail";
            }

            Console.Clear();



            //Console.WriteLine("Your Report");
            //Console.WriteLine("Math       : " + math);
            //Console.WriteLine("Physics    : " + physics);
            //Console.WriteLine("Chemistry  : " + chemistry);
            //Console.WriteLine("Urdu       : " + urdu);
            //Console.WriteLine("________________________");
            //Console.WriteLine("Total Marks: " + totalMarks);
            //Console.WriteLine("Percentage : " + percentage + " %");
            //Console.WriteLine("Average    : " + average);
            //Console.WriteLine("Division   : " + division);


            //Console.WriteLine("Your Report \n" +
            //                  "Math     : {0}\n" +
            //                  "Physics  : {1}\n" +
            //                  "Chemistry: {2}\n" +
            //                  "Urdu     : {3}",
            //                  math,
            //                  physics,
            //                  chemistry,
            //                  urdu);


            //Console.WriteLine($"Your Report\n" +
            //                  $"Math     : {math}\n" +
            //                  $"Physics  : {physics}\n" +
            //                  $"Chemistry: {chemistry}\n" +
            //                  $"Urdu     : {urdu}\n");

            Console.ReadKey();

        }
    }
}
