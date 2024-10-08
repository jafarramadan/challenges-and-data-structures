﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.LeafSum;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    
    public class LeafSum_Tests
    {
        [Fact]
        public void calculatingSumPositive()
        {
            //arrange
            BinaryTree Btree = new BinaryTree(9);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(12);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(17);
            Btree.Root.Right.Right = new TNode(23);
            Btree.Root.Left.Left.Right = new TNode(4);

            //act 
            Leaf_SumClass leaf_SumClass = new Leaf_SumClass();
           int sum= leaf_SumClass.SumLeaf(Btree.Root);

            //assert 
            Assert.Equal(51, sum);
        }

        [Fact]
        public void calculatingSumNegative()
        {
            //arrange
            BinaryTree Btree = new BinaryTree(-9);
            Btree.Root.Left = new TNode(-8);
            Btree.Root.Right = new TNode(-12);
            Btree.Root.Left.Left = new TNode(-3);
            Btree.Root.Left.Right = new TNode(-7);
            Btree.Root.Right.Left = new TNode(-17);
            Btree.Root.Right.Right = new TNode(-23);
            Btree.Root.Left.Left.Right = new TNode(-4);

            //act 
            Leaf_SumClass leaf_SumClass = new Leaf_SumClass();
            int sum = leaf_SumClass.SumLeaf(Btree.Root);

            //assert 
            Assert.Equal(-51, sum);
        }
    }
}
