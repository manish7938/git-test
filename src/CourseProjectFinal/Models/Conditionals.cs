using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Models
{
    public class Conditionals
    {
        public void conditional()
        {
            // If Statement
            int first = 1;
            int second = 2;

            if (second > first)
            {

                Console.WriteLine("Second is greater than First");
            }else
            {

                Console.WriteLine("First is greater than First");

            }

            // shorthand condional

            string value ="";

            value = (second > first) ? "Second is greater than First" : "First is greater than First";
            Console.WriteLine(value);


            // Switch

            int mycase = 4;

            switch (mycase)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("None");
                    break;

            }

            // for loop

            for(int z = 0; z <= 20; z++)
            {

                Console.WriteLine(z);

            }

            // foreach

            //foreach (var item in collection)
           // {

          //  }

            // While
            int f = 0; 

            while(f < 20)
            {
                Console.WriteLine(f);


            }

            // Do while

            int d = 0;

            do
            {

                Console.WriteLine(d);
                d++;

            } while (d <= 60);




        }


    }
}
