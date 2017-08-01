using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    //The following program will ask the user to enter their first name, middle name and last name
    //then concatenate the three inputs and display it in one line.  
    {
        static void Main(string[] args)
        {
            // User input first name
            Console.WriteLine("What is your Full Name?");
            Console.WriteLine("Type your first name : ");
            string myfirstname= Console.ReadLine();
   
            // User input middle name
            Console.WriteLine("Type your middle name : ");
            String mymidlename = Console.ReadLine();

            // User input last name
            Console.WriteLine("Type your last name : ");
            string mylastname = Console.ReadLine();

            // Full name display        
            Console.WriteLine("Hello  "+ myfirstname +" "+ mymidlename+ " "+ mylastname);
            Console.ReadLine();
        }
   


            }

}
