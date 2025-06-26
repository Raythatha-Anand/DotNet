using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withFrameWork
{
    internal class sum
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int op;
            int result=0;
            Console.Write("1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n");
            Console.Write("Enter 1st number: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter 2nd number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation (1-4): ");
            op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                result = a + b;
                Console.WriteLine("The addition of " + a + " and b " + b + " is " + result);

            }
            else if(op == 2)
            {
                result = a - b;
                Console.WriteLine("The subtraction of " + a + " and b " + b + " is " + result);


            }
            else if(op == 3)
            {
                result = a * b;
                Console.WriteLine("The multiplication of " + a + " and b " + b + " is " + result);


            }
            else if(op == 4)
            {
                result = a / b;
                Console.WriteLine("The division of "+ a+ " and b "+ b + " is "+ result);


            }
            else
            {
                Console.WriteLine("Invalid operation selected.");
               
            }
            Console.WriteLine("Program Finished")



            
            
        }
    }
}
