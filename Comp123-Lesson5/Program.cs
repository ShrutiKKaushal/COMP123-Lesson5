using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            
           string[] originalArray = {"Honda", "BMW", "Mercedes","Jeep","Ford","Jaguar"}; // literal notation or string initializer

           string[] tempArray = new string[originalArray.Length];

           string[] finalArray = new string[3];


           Random rnd = new Random();

           int randomElement;

            //Copy each element of original array to temp array
           for(int element = 0; element < originalArray.Length; element++)
           {
               tempArray[element] = originalArray[element];
           }
            //Assign cells from one array to another
            /* Alternate looping structure
           for (int index = 0; index < finalArray.Length; index++)
           {
               randomElement = generateRandomElement(rnd);

               if (originalArray[randomElement] != "Unavailable")
               {
                   finalArray[index] = originalArray[randomElement];
                   originalArray[randomElement] = "Unavailable";
               }
              
           }
            */


           
          int index = 0;

          while (index < finalArray.Length)
           {

               randomElement = generateRandomElement(rnd, originalArray.Length); // Generate random number

               if (tempArray[randomElement] != "Unavailable")
               {
                   finalArray[index] = tempArray[randomElement];

                   tempArray[randomElement] = "Unavailable";
                  
                   index++;
               }
               
           }
          

            //Output the value of each cell in each array
           Console.WriteLine("++++++++++++++++++++++");
           Console.WriteLine("+  Original Car List +");
           Console.WriteLine("++++++++++++++++++++++");
               for ( index = 0; index < originalArray.Length; index++)
               {
                   Console.WriteLine(originalArray[index]);

               }
               Console.WriteLine("++++++++++++++++++++++");
               Console.WriteLine("+    New Car List    +");
               Console.WriteLine("++++++++++++++++++++++");
               for ( index = 0; index < finalArray.Length; index++)
               {
                   
                   Console.WriteLine(finalArray[index]);
               }
               
            
            /* Alternate way to declare and initialize an array

            string[] originalArray = new string[6];

            originalArray[0] = "Jaguar";
            originalArray[1] = "Honda";
            originalArray[2] = "BMW";
            originalArray[3] = "Mercedes";
            originalArray[5] = "Jeep";
            originalArray[6] = "Ford";
            */
            /* Alternate Method to loop through (iterate across the array)
           int index = 0;
            while(index < originalArray.Length)
            {
                Console.WriteLine(originalArray[index]);
                index++;
            }
            */


            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        private static int generateRandomElement(Random rnd, int max)
        {
            int number;
            number = rnd.Next(max);
           // Console.WriteLine("My random Car is {0}", number);//Debugging line
            return number;
        }
    }
}
