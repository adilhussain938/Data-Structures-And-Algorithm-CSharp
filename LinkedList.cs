using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class linkedlist
    {
        Node head;
        Node tail;
        int Size;

        public void insertlast(int i, Node Next =null)
        {
            Node newest = new Node(i,Next);
            if (head == null)
            {
                head = newest;
                tail = newest;
                Size++;
            }
            else
            {
                tail.Next = newest;
                tail = newest;
                Size++;
            }

        } 
        public void insertFirst(int i, Node Next =null)
        {
            Node newest = new Node(i,Next);
            if (head == null)
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.Next=head;
                head = newest;
            }

        }
        public void AddAfterSpecific(int i,int Size )
        {

            Node prev = new Node();
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Node temp = head;
            prev = head;

            if(this.Size<Size)
            { 
                while (temp != null && Size != this.Size)
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp.Element == i)
                {
                    prev.Next = prev.Next.Next;
                }
                }
            else
            {
                Console.WriteLine("Please Enter Correct Position in Range");
            }
        }
        public void removeAfterSpecific(int i)
        {

            Node prev =new Node();
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Node temp = head;
             prev = head;

            while (temp!=null && temp.Element !=i)
            {
                prev = temp;
                temp = temp.Next;
            }
            if(temp.Element ==i)
            {
                prev.Next = prev.Next.Next;
            }

        }
        public void prinlist()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write("->");
                Console.Write(   temp.Element);
                
                temp = temp.Next;
            }

        }

    }
   
}
