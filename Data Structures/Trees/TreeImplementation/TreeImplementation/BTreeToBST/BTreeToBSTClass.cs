using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation.BTreeToBST
{
    public class BTreeToBSTClass
    {
       
        public TNode ArrayToBst(int[] array)
        {
            if (array == null) return null;
            return ArrayHelper(array, 0, array.Length - 1);

        }
        public TNode ArrayHelper(int[] array, int a, int b)
        {
            if (a > b) return null;
            int mid = a + (b - a) / 2;
            TNode node = new TNode(array[mid]);
            node.Left = ArrayHelper(array, a, mid - 1);
            node.Right = ArrayHelper(array, mid + 1, b);

            return node;

        }
    }
}
