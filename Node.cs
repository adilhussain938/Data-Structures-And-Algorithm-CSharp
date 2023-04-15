using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Node
    {
        public Node()
        {

        }
        public int Element { get; set; }
         public Node Next { get; set; }

        public Node(int i, Node J)

        {
            Element = i;
            Next = J;
        }
    }
}
