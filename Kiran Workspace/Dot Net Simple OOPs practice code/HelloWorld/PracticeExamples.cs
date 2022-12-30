using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PracticeExamples : Baseclass
    {
        //------- Swapping two numbers------------// 
        public void swapNumber()  
        {
            int x, y;
            Console.WriteLine("Enter x =");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y =");
            y = int.Parse(Console.ReadLine());
            int temp;
            Console.WriteLine("Before swaping " + "x = " + x + " " + "y = " + y + "\n");
            temp = x; //temp = 10 and x= 10 , y = 99
            x = y; //temp = 10 and x= 99 , y = 99
            y = temp; //temp = 10 and x = 99, y = 10
            Console.WriteLine("After swaping " + "x = " + x + " " + "y = " + y);
        }

        //------- Find the Prime numbers------------// 
        public void primeNum()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
    
}
