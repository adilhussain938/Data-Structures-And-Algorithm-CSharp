using BinarySearchTree;
using DoublyLinkedList;
using Practice_Programs;
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
            BinarySearchTrees bst1 = new BinarySearchTrees();
            //bst.root = bst.RecursiveApproach(null, 50);
            //bst.RecursiveApproach(bst.root, 60);
            //bst.RecursiveApproach(bst.root, 10);
            //bst.RecursiveApproach(bst.root, 5);
            //bst.RecursiveApproach(bst.root, 15);
            //bst.RecursiveApproach(bst.root, 55);
            //var a = new  List<int>();
            //bst.hasPath(bst.root, a, 55);

            //         50
            //       /   \
            //    10     60
            //  /  \   /  \
            //5    15  55   
            //bst.RecursiveApproach(bst.root, 70);
            //Console.WriteLine(bst.MaxElement(bst.root));
            //bst.nodeofTree(bst.root);
            //bst1.root = bst.RecursiveApproach(null, 50);
            //bst1.RecursiveApproach(bst1.root, 60);
            //bst1.RecursiveApproach(bst1.root, 10);
            //bst1.RecursiveApproach(bst1.root, 20);

            //bst.mirror(bst.root);
            //Console.WriteLine(   bst.identicalTrees(bst.root,bst1.root));

            //Console.WriteLine(   bst.HightOfTree(bst.root));
            //bst.RecursiveApproach(bst.root, 40);
            //bst.RecursiveApproach(bst.root, 80);
            //bst.RecursiveApproach(bst.root, 5);
            //bst.RecursiveApproach(bst.root, 42);
            //bst.RecursiveApproach(bst.root, 4);
            //    bst.RecursiveApproach(bst.root, 55);
            //    bst.RecursiveApproach(bst.root, 35);
            //    bst.RecursiveApproach(bst.root, 8);


            // bst.searchbinarytree(bst.root, 60);

            //bst.RecursiveApproach(bst.root, 55);
            //bst.RecursiveApproach(bst.root, 90);
            //bst.TrverseInorder(bst.root)
            //Console.WriteLine("---------------preorder------------");

            //bst.deletenode(bst.root, 10, bst.root);

            //Console.WriteLine("---------------preorder after deleting------------");
            //bst.TrverseInorder(bst.root);

            //bst.Trversepreorder(bst.root);

            //bst.RecursiveApproach(bst.root, 2);
            //bst.RecursiveApproach(bst.root, 7);
            //bst.RecursiveApproach(bst.root, 1);

            //bst.LeftViewOfTree(bst.root);
            //bst.MergeTwoSorted();
            ////bst.arrachar();
            //int[] arr = new int[] { 7, 5, 1 };
            //PracticeProgram a = new PracticeProgram();
            //Console.WriteLine(   a.minCoins(18, arr)); 


            #endregion
            #region heap

            //hp.insertinheap(12);
            //hp.insertinheap(1);
            //hp.insertinheap(122);
            SlidingWindowProblems aaa = new SlidingWindowProblems();
            aaa.PrintFirstNegativeNumberQueue();

            #endregion
            Console.ReadLine();

        }
    }
}
