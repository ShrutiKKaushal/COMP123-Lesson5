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

            
           string[] carMakeList = {"Honda", "BMW", "Mercedes","Jeep","Ford"};

           string[] tempCarMakeList = new string[3];


           Random rnd = new Random();

           int randomCar;

           

            //Assign cells from one array to another
           for (int index = 0; index < tempCarMakeList.Length; index++)
           {
               randomCar = generateRandomCar(rnd);

               if (carMakeList[randomCar] != "Unavailable")
               {
                   tempCarMakeList[index] = carMakeList[randomCar];
                   carMakeList[randomCar] = "Unavailable";
               }
              
           }


            //Output the value of each cell in each array
           Console.WriteLine("++++++++++++++++++++++");
           Console.WriteLine("+  Original Car List +");
           Console.WriteLine("++++++++++++++++++++++");
               for (int index = 0; index < carMakeList.Length; index++)
               {
                   Console.WriteLine(carMakeList[index]);

               }
               Console.WriteLine("++++++++++++++++++++++");
               Console.WriteLine("+    New Car List    +");
               Console.WriteLine("++++++++++++++++++++++");
               for (int index = 0; index < tempCarMakeList.Length; index++)
               {
                   
                   Console.WriteLine(tempCarMakeList[index]);
               }
               
            
            /* Alternate way to declare and initialize an array

            string[] carMakeList = new string[6];

            carMakeList[0] = "Jaguar";
            carMakeList[1] = "Honda";
            carMakeList[2] = "BMW";
            carMakeList[3] = "Mercedes";
            carMakeList[5] = "Jeep";
            carMakeList[6] = "Ford";
            */
            /* Alternate Method to loop through (iterate across the array)
           int index = 0;
            while(index < carMakeList.Length)
            {
                Console.WriteLine(carMakeList[index]);
                index++;
            }
            */


            
           
           

            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        private static int generateRandomCar(Random rnd)
        {
            int randomCar;
            randomCar = rnd.Next(5);
            Console.WriteLine("My random Car is {0}", randomCar);//Debugging line
            return randomCar;
        }
    }
}
