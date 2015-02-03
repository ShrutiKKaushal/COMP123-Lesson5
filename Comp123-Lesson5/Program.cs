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

            
           string[] originalArray = {"Honda", "BMW", "Mercedes","Jeep","Ford"};

           string[] newArray = new string[3];


           Random rnd = new Random();

           int randomMember;

           

            //Assign cells from one array to another
            /* Alternate looping structure
           for (int index = 0; index < newArray.Length; index++)
           {
               randomMember = generateRandomMember(rnd);

               if (originalArray[randomMember] != "Unavailable")
               {
                   newArray[index] = originalArray[randomMember];
                   originalArray[randomMember] = "Unavailable";
               }
              
           }
            */



           
          int index = 0;
          while (index < newArray.Length)
           {

               randomMember = generateRandomMember(rnd);
               if (originalArray[randomMember] != "Unavailable")
               {
                   newArray[index] = originalArray[randomMember];
                  
                   originalArray[randomMember] = "Unavailable";
                  
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
               for ( index = 0; index < newArray.Length; index++)
               {
                   
                   Console.WriteLine(newArray[index]);
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

        private static int generateRandomMember(Random rnd)
        {
            int randomCar;
            randomCar = rnd.Next(5);
            Console.WriteLine("My random Car is {0}", randomCar);//Debugging line
            return randomCar;
        }
    }
}
