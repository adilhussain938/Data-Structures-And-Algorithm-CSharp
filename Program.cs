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

           // DoublyLinkedLst ls = new DoublyLinkedLst();
           // ls.insertatlast(4, null, null);
           // ls.insertatlast(14, null, null);
           // ls.insertatlast(124, null, null);
           // ls.insertatlast(43, null, null);
           // ls.insertatlast(445, null, null);
           // ls.printList();

           // ls.DeletefromLaast();

           //// ls.DeleteAtSpecificPosition(2,2);
           // ls.printList();
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
            //bst.root = bst.RecursiveApproach(null,50);
            //bst.RecursiveApproach(bst.root, 60);
            //bst.RecursiveApproach(bst.root, 10);
            //bst.RecursiveApproach(bst.root, 40);
            //bst.RecursiveApproach(bst.root, 80);
            ////bst.RecursiveApproach(bst.root, 60);

            //bst.RecursiveApproach(bst.root, 55);
            //bst.RecursiveApproach(bst.root, 90);
            //bst.TrverseInorder(bst.root);
            //Console.WriteLine("---------------preorder------------");
            //bst.Trversepreorder(bst.root);

            //bst.RecursiveApproach(bst.root, 2);
            //bst.RecursiveApproach(bst.root, 7);
            //bst.RecursiveApproach(bst.root, 1);

            //bst.LeftViewOfTree(bst.root);
            //bst.MergeTwoSorted();
            bst.arrachar();
            
            #endregion
            Console.ReadLine();

        }
    }
}
