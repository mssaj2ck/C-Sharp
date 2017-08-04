using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        { // This program illustrate two ways to initialize arrays, 
          //displays the arrays in a row and in a column form. Lastly it will display a specific value index.   
          
            //Declare a seven integer array "number" and give a value to each index in the array 
            int[] number = new int[6];
            number[0] = 14;
            number[1] = 18;
            number[2] = 115;
            number[3] = 61;
            number[4] = 32;
            number[5] = 82;

            //Declaring and assigning values to a six integer array "numbers" 
           int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            //Declaring and assigning values to a six integer array "numbers" 
            string[] names = new string[] { "Alex", "Eddy", "Minnie", "Bravo", "Max", "Jhonny" };

            //Displays the index assigned to the correspondent value of the array named "number",
            // also displays the array in a column list form by using "Console.WriteLine"
            Console.WriteLine("The array named number is :\n");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(" Number {0} = {1}", i, number[i] );
            }
            Console.WriteLine("\n\n");

            //Displays the array named "numbers" side by side in a row by using "Console.Write"
            Console.WriteLine("The array named numbers is :\n");
            for (int i = 0; i < numbers.Length; i++)
            {                
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\n\n");

            //Displays the array named "names" in a columm list by using "Console.WriteLine"
            Console.WriteLine("The array named names is :\n");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]+" ");
            }
            Console.WriteLine("\n\n");

            //Displays the values of a specific index
            Console.WriteLine("\n\nDisplyas the values of a specific index");     	
            Console.WriteLine("\nThe first index values of the respective arrays are : {0}, {1}, {2}", number[0], numbers[0], names[0]);
            Console.WriteLine("\nThe double of the fifth number of the first and second arrays are : {0}, {1}",(number[4]*2),(numbers[4]*=2));
            Console.WriteLine("\nThe fourth value of the arrays are : {0}, {1}, {2}",number[3] ,numbers[3],names[3]);
            Console.WriteLine("\n\n");
        }
       
            }
  
            }
      
