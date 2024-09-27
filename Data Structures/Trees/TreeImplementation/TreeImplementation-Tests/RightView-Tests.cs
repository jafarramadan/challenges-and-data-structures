using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.RightViewPrint;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class RightView_Tests
    {
        [Fact]
        public void TestRightView()
        {
            //arrange 
            BinaryTree Btree = new BinaryTree(2);
            Btree.Root.Left = new TNode(3);
            Btree.Root.Right = new TNode(5);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Right = new TNode(7);

            //act
            PrintRightViewClass PRVC = new PrintRightViewClass();
            List<int> ActualLsit = PRVC.PrintRightView(Btree.Root);
            List<int> ExpectedLsit = new List<int>() { 2,5,6,7};



            //assert
            Assert.Equal(ExpectedLsit, ActualLsit);

        }

        [Fact]
        public void TestRightViewWithOnlyRightSide()
        {
            //arrange 
            BinaryTree Btree = new BinaryTree(2);
            Btree.Root.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);

            //act
            PrintRightViewClass PRVC = new PrintRightViewClass();
            List<int> lsit = PRVC.PrintRightView(Btree.Root);
            
            //assert

            Assert.True(lsit.Count <= 0);
        }
    }
}
