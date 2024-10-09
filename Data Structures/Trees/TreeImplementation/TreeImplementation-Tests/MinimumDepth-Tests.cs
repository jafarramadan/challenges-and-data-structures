using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.MinimumDepth;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class MinimumDepth_Tests
    {
        [Fact]
        public void Test_Minimum_Depth_With_Multiple_Nodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
          
            // Act
            MinimumDepthClass minimumDepthClass = new MinimumDepthClass();
            int result = minimumDepthClass.FindMinimumDepth(Btree.Root);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_Minimum_Depth_With_Skewed_Tree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Right.Right = new TNode(6);


            // Act
            MinimumDepthClass minimumDepthClass = new MinimumDepthClass();
            int result = minimumDepthClass.FindMinimumDepth(Btree.Root);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test_Minimum_Depth_Empty_Tree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(0); 
            Btree.Root = null;

            // Act
            MinimumDepthClass minimumDepthClass = new MinimumDepthClass();
            int result = minimumDepthClass.FindMinimumDepth(Btree.Root);

            // Assert
            Assert.Equal(0, result); 
        }

        [Fact]
        public void Test_Minimum_Depth_Single_Node()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);

          
            // Act
            MinimumDepthClass minimumDepthClass = new MinimumDepthClass();
            int result = minimumDepthClass.FindMinimumDepth(Btree.Root);

            // Assert
            Assert.Equal(1, result); 
        }
    }
}
