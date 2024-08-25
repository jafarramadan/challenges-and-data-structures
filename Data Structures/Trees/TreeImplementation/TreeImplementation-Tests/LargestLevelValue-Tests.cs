using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.LargestLevelValue;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class LargestLevelValue_Tests
    {
        [Fact]
        public void LargestLevelValue_Test()
        {
            //arrange
            BinaryTree Btree = new BinaryTree(5);
            Btree.Root.Left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.Left.Left.Left = new TNode(1);
            Btree.Root.Left.Left.Right = new TNode(4);
            Btree.Root.Right.Left.Right = new TNode(11);

            //act
            LargestLevelValueClass largestLevelValue = new LargestLevelValueClass();
            List<int> largestValues = largestLevelValue.LargestLevelValue(Btree);
           int x= largestValues.Sum();
            int y = 49;

            //assert 
            Assert.Equal(y, x);
        }
    }
}
