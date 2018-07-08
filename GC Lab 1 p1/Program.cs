using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_1_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test());

            Console.ReadKey();
        }

        static bool Test()
        {
            //Two inputs from user
            //Assumed positive numbers would be used, will fail if negative numbers or other mark up characters such as a comma are used
            //assignment was non specific and only used three digit positive numbers in the example given

            Console.WriteLine("Please enter a number: ");
            string x = Console.ReadLine();

            Console.WriteLine("Please enter a second number of the same length: ");
            string y = Console.ReadLine();

            //length check if lengths are the same proceed to int check
            if (x.Length != y.Length)
            {
                Console.WriteLine("You did not enter numbers of the same length");
                return false;
            }

            //int check if they are both ints, we don't care about value so junk is used, proceed to do the sum comparison
            int junk;
            bool num1 = int.TryParse(x, out junk);
            bool num2 = int.TryParse(y, out junk);

            if (!(num1 && num2))
            {
                Console.WriteLine("You did not enter numbers");
                return false;
            }

            //This is the test check to see if the sum of the first place in both numbers has the 
            //same value of the sum of the next place of numbers.  If it does not it stops the loop
            //returning false

            int firstSum = 0;
            bool isSuccessful = true;

            for (int index = 0; index < x.Count(); index++)
            {
                char charFromFirstString = x[index];
                char charFromSecondString = y[index];

                int firstCharAsInt = Convert.ToInt32(charFromFirstString);
                int secondCharAsInt = Convert.ToInt32(charFromSecondString);

                int sumCharAndChar = firstCharAsInt + secondCharAsInt;

                if (index == 0)
                {
                    firstSum = sumCharAndChar;
                }
                else if (firstSum != sumCharAndChar)
                {
                    isSuccessful = false;
                    break;
                }
            }

            return isSuccessful;
        }
    }
}