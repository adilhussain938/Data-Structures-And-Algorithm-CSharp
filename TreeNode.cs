using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode
    {
        public int? Element { get; set; }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int? Element, TreeNode Left = null, TreeNode Right= null)
        {
            this.Element = Element;
            this.Left = Left;
            this.Right = Right;
        }
    }
}
