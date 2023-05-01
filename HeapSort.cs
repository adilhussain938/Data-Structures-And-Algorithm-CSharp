using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    public  class HeapSort
    {

        int[] heap = new int[100];

        int HSize = 0;
        int csize = 0;

        public void insertinheap(int element)
        {
            csize = csize + 1;

            int hi = csize;

            while (hi>1 && element > heap[hi/2])
            {
                heap[csize] = heap[csize/2];
                hi = hi / 2;

            }
            heap[csize] = element;

        }

    }
}
