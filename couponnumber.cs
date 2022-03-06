using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograms
{
    public class couponnumber
    {
        public static void coupon_number()
        {
            int max_length = 6;
            Random random = new Random();
            int number = random.Next(10);

            Random numberGen = new Random();
            int amountToOutput = 1;
            int minimumRange = 1000000;
            int maximumRange = 99999;

            for (int i = 0; i < amountToOutput; i++)

            {
                int randomNumber = numberGen.Next(maximumRange,minimumRange);
                Console.WriteLine(randomNumber);
               

            }
        }
    }
}





