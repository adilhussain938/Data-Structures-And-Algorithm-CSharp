using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
   
    
    
    public  class Program
    {
        static void Main(string[] args)
        {

            linkedlist a = new linkedlist();

            a.insertlast(3, null);

            a.insertlast(4, null);
            a.insertlast(164, null);
            a.insertlast(154, null);
            a.insertlast(114, null);
            a.insertlast(124, null);
            a.insertFirst(3, null);

            a.removeAfterSpecific(124);
            a.prinlist();
            Console.ReadLine();

        }
    }
}
