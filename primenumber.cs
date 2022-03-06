using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograms
{
    public class primenumber
    {
        public static void prime_number()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for(i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.Write("Number is not prime");
                    flag = 1;
                    break;

                }
                if(flag==0)
                {
                    Console.Write("Number is Prime");
                    break;
                }
            }
        }
    }
}
