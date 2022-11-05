using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Bhavani_PrimeOrNot
{
    public  class PrimeNumber1
    {
     public void PrimeNumberMethod()
        {
            int n , i;
            Console.WriteLine("Enter number:");
            n =Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (i = 1; i <= n; i++)
            {
                if (n / i == 0)
                {
                    c++;
                }
            }
                if (c == 2)
                {
                    Console.WriteLine("given number is PrimeNumber");
                }
                else
                {
                    Console.WriteLine("The given number is not a primenumber");
                }
            

        }
    }
}
