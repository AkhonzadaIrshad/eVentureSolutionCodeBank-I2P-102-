using System;
namespace ConsoleApp
{

    //What is OOP (Object Oriented Programming)

    //class Fan //Title Case
    //{
    //    public int wings;
    //    public string companyName;//Camel Case
    //}


    class Student
    {
        //Fields
        public string name;
        public string fatherName;
        public int rollNumber;
        public double fees;

    }






    class Program
    {
        static void Main(string[] args)
        {

            //Fan obj=new Fan();
            //obj.wings = 3;
            //obj.companyName = "PAK Fan";


            //Console.WriteLine("Welcome to FAN Factory\n" +
            //                  "Fan Features : \n" +
            //                  $"Number Of Wings  : {obj.wings}\n" +
            //                  $"From to House of : {obj.companyName}");

            //Fan job=new Fan();


            //Object Oriented Programming 
            //To Map Reall World
            //To Create User Define DataTypes



           // Student[] students=new Student[10];


            Student first=new Student();

            first.name = "Shahid";
            first.fatherName = "Riyaz";
            first.rollNumber = 123;
            first.fees = 1000.0;


            Student second=new Student();
            second.name = "Ahmed";
            second.fatherName = "Ali";
            second.rollNumber = 321;
            second.fees = 3000.0;



            Console.WriteLine("Student Records\n" +
                              "____________FIRST_________________ \n" +
                              $"Name         : {first.name       }\n" +
                              $"Father Name  : {first.fatherName }\n" +
                              $"RollNumber   : {first.rollNumber }\n" +
                              $"Fees         : {first.fees       }\n" +
                              $"___________SECOND________________ \n"+
                              $"Name         : {second.name      }\n" +
                              $"Father Name  : {second.fatherName}\n" +
                              $"RollNumber   : {second.rollNumber}\n" +
                              $"Fees         : {second.fees      }\n" +
                              $"________________________________");





            Console.ReadKey();
        }
    }
}
