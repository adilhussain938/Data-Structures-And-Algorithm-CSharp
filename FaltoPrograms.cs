using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    internal class FaltoPrograms
    {

        public void printnumbers(int i)
        {
            if (i == 0)
            {
                return;
            }
            printnumbers(i - 1);
            Console.WriteLine(i);
            return;
        }
        public int factorial(int i)
        {
            if (i == 1)
            {
                return 6;
            }

            var j = i * factorial(i - 1);

            return j;
        }
        public bool powerofTwo(int i)
        {
            if (i == 1)
                return true;
            if (i % 2 == 0 && powerofTwo(i / 2))
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        //public bool isPowerOfTwo(int n)
        //{
        //    if (n == 0) 
        //        return false;
        //    else if ((n == 1) || (n % 2 == 0 && isPowerOfTwo(n / 2))) 
        //        return true;
        //    else 
        //        return false;
        //}

        public void falto()
        {
            




    //    for (var j = 0; j< 3; j++)
    //        {
    //            for (var i = 0; i< 5; i++)
    //            {
    //                Console.WriteLine(i);
    //            }
    //Console.WriteLine("");
    //        }

    //        //int val = 5;
            //int i, j, k;
            //for (i = 1; i <= val; i++)
            //{
            //    for (j = 1; j <= val - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
    }

    }

}
