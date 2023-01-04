using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Loops : Baseclass
    {
        public void loop()
        {
            Console.WriteLine("If loop \n");
            int i = 0;
            int myNum = 0;
            if (myNum >= 5)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("bingo");
            }
            Console.WriteLine("while loop \n");
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("For loop \n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array and for loop \n");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }

}

