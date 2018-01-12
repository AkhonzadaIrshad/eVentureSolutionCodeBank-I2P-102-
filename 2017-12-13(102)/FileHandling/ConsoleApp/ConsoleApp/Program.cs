using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter writer=new StreamWriter("TextFile.txt");
            //writer.WriteLine("First Text From Application");
            //writer.Close();
            StreamReader reader=new StreamReader("TextFile.txt");
            while (reader.ReadLine()!=null)
            {
                Console.WriteLine(reader.ReadLine());
            }
            



            Console.ReadKey();



        }
    }
}
