using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTrees
    {
        TreeNode Head; 
        int Size = 1;
        public TreeNode root;
        public BinarySearchTrees()
        {
            root = null;
        }


        public void searchbinarytree(TreeNode Head, int Element)
        {
            if (Head !=null)
            {
                if(Head.Element == Element)
                {
                    Console.WriteLine("Foud Element at"+ Element);
                    return;
                }
                if(Element < Head.Element )
                { 
                    searchbinarytree(Head.Left, Element);
                }
                else if ( Element > Head.Element)
                { 
                    searchbinarytree(Head.Right, Element);
                }

            }
            

        }
        public int nodeofTree(TreeNode Node)
        {
            if (Node !=null)
            {
                int x = nodeofTree(Node.Left);
                int y = nodeofTree(Node.Right);
                return x + y + 1;

            }
            return 0;

        }
        public int HightOfTree(TreeNode Node)
        {
            if (Node !=null)
            {
                int x = HightOfTree(Node.Left);
                int y = HightOfTree(Node.Right);
                if (x > y )
                {
                    return x + 1;
                }
                else
                {
                    return y + 1;
                }
            }
            return 0;

        }

        public void deletenode(TreeNode treeNode, int element,TreeNode prev)
        {
            
            if (treeNode!=null )
            {
                if (element == treeNode.Element)
                {
                    if (treeNode.Left == null && treeNode.Right ==null)
                    { 
                        if (prev.Element> element)
                        {
                            prev.Left = null;
                        }
                        else
                        {
                            prev.Right = null;
                        }
                    }
                    else if (treeNode.Left != null && treeNode.Right ==null)
                    {
                        prev.Left = treeNode.Left;
                    }
                    else if (treeNode.Left == null && treeNode.Right !=null)
                    {
                        prev.Right = treeNode.Right;
                    }
                    else 
                    {
                        TreeNode t = treeNode.Left;
                        TreeNode par =t;
                        while(t.Right != null)
                        {
                            par = t;
                            t = t.Right;
                        }
                        treeNode.Element = t.Element;
                        par.Right = null;


                    }
                }
                if(element < treeNode.Element)
                {
                    prev = treeNode;
                    deletenode(treeNode.Left, element,prev);
                }
                else
                {
                    prev = treeNode;
                    deletenode(treeNode.Right, element, prev);

                }
            }


        }


        public TreeNode RecursiveApproach(TreeNode root,int Element)
        {
            //TreeNode pre = root;

            if (root!=null)
            {
                if (Element < root.Element)
                {
                    root.Left = RecursiveApproach(root.Left, Element);
                }
                else
                {
                    root.Right = RecursiveApproach(root.Right, Element);
                }
            }
            else
            {
                TreeNode newnode = new TreeNode(Element,null,null);
                
                    root = newnode;
                
            }
            return root;
                

        }

        public void TrverseInorder(TreeNode Root)
        {

            if (Root != null)
            {

                TrverseInorder(Root.Left);
                Console.WriteLine(Root.Element);
                TrverseInorder(Root.Right);

            }

        }
        public void Trversepreorder(TreeNode Root)
        {

            if (Root != null)
            {
                Console.WriteLine(Root.Element);
                TrverseInorder(Root.Left);
                TrverseInorder(Root.Right);

            }

        }
        public void Trverseppostorder(TreeNode Root)
        {

            if (Root != null)
            {
                TrverseInorder(Root.Left);
                TrverseInorder(Root.Right);
                Console.WriteLine(Root.Element);

            }

        }
        public void LeverorderTraversal(TreeNode root)
        {

            Queue<TreeNode> nodeque = new Queue<TreeNode>();
            
            nodeque.Enqueue(root);
            TreeNode temp = root;

            while (nodeque.Count()>0)
            {
                temp = nodeque.Dequeue();
                if (temp.Left != null)
                {
                    nodeque.Enqueue(temp.Left);
                    Console.WriteLine(temp.Left.Element);    
                }
                if (temp.Right != null)
                {
                    nodeque.Enqueue(temp.Right);

                    Console.WriteLine(temp.Right.Element);
                }

            }

        }
        public void LeftViewOfTree(TreeNode root)
        {

            Queue<TreeNode> nodeque = new Queue<TreeNode>();
            
            nodeque.Enqueue(root);
            Console.WriteLine(root.Element);
            nodeque.Enqueue(null);
            TreeNode temp = root;
            List<int> a = new List<int>();

            while (nodeque.Count()>0)
            {
                temp = nodeque.Dequeue();
                if (temp==null)
                {
                    if (nodeque.Count() == 0)
                    {
                        return;
                    }
                    if(nodeque.Count()>0)
                    {
                        nodeque.Enqueue(null);
                        Console.WriteLine(a.Last());
                        //Console.WriteLine(" ");
                        a = new List<int>();
                        continue;
                    }
                }
                if (temp.Left != null)
                {
                    nodeque.Enqueue(temp.Left);
                    //Console.Write(temp.Left.Element +" ");
                    a.Add((int)temp.Left.Element);
                }
                if (temp.Right != null)
                {
                    nodeque.Enqueue(temp.Right);

                    //Console.Write(temp.Right.Element+" ");
                    a.Add((int)temp.Right.Element);
                }

            }

        }


        public void CreateTreeforwhileLoop(int element)
        {
            Size++;
            TreeNode tempointer = new TreeNode(1,null,null);
            if (Head ==null)
            {
                TreeNode newnode = new TreeNode(element, null, null);
                Head = newnode;
                
            }
            // Using While 
            else if (true)
            {
                TreeNode temps = Head;
                
                while (temps != null)
                {
                     tempointer = temps;
                    if(temps.Element == element)
                    {
                        return;
                    }
                    else if (element <temps.Element )
                    {
                        temps = temps.Left;
                    }
                    else
                    {
                        temps = temps.Right;
                    }
                }

                if(element< tempointer.Element)
                {
                    
                    TreeNode newwst = new TreeNode(element, null, null);
                    tempointer.Left = newwst;

                }
                else
                { 
                    TreeNode newwst1 = new TreeNode(element, null, null);
                    tempointer.Right = newwst1;
                }









            }
            // Usinf For Loop
            else
            {
                TreeNode temp = Head;
                
                for(int i=1;i<Size;i++)
                {
                      if (element < temp.Element) 
                      {
                            if(temp.Left!=null)
                            {   
                                temp = temp.Left;
                            }
                        
                            else
                            { 
                                var newnode = new TreeNode(element, null, null);
                                temp.Left = newnode;
                                temp = newnode;
                                break;     
                            }
                      }
                      else
                      {
                            if (temp.Right != null)
                            {
                                temp = temp.Right;
                            }
                            else
                            { 
                                var newnode = new TreeNode(element, null, null);
                                temp.Right = newnode;
                                temp = newnode;
                                break;
                            }
                      }

                    
                }
            }

        }

    }
}
