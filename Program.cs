using BinarySearchTree;
using DoublyLinkedList;
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



            #region DoublyLinked List

            DoublyLinkedLst ls = new DoublyLinkedLst();
            ls.insertatlast(4, null, null);
            ls.insertatlast(14, null, null);
            ls.insertatlast(124, null, null);
            ls.insertatlast(43, null, null);
            ls.insertatlast(445, null, null);
            ls.printList();

            ls.DeletefromLaast();

           // ls.DeleteAtSpecificPosition(2,2);
            ls.printList();
            #endregion

            #region Singly LinkedList
            //linkedlist a = new linkedlist();

            //a.insertlast(3, null);

            //a.insertlast(4, null);
            ////a.insertlast(164, null);
            ////a.insertlast(154, null);
            ////a.insertlast(114, null);
            ////a.insertlast(124, null);
            ////a.insertFirst(3, null);
            ////a.AddAfterSpecific(67, 5);
            ////a.removeAfterSpecific(124);
            //a.prinlist();
            //Console.WriteLine("\n-------------------------------------------");
            //a.PrintReverseList();
            //a.prinlist();
            #endregion

            #region BinarySearchTrees
            BinarySearchTrees bst = new BinarySearchTrees();
            bst.CreateTree(8);
            bst.CreateTree(5);
            bst.CreateTree(6);
            bst.CreateTree(9);

            #endregion
            Console.ReadLine();

        }
    }
}
