using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.MaxLEvelNodes;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class MaxLevelNodes_Tests
    {
        [Fact]
        public void FindMaxLevelNodes_FirstExample_ReturnsCorrectLevel()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);

            MaxLevelNodesClass analyzer = new MaxLevelNodesClass();

            // Act
            int result = analyzer.FindMaxLevelNodes(Btree.Root);

            // Assert
            Assert.Equal(2, result); 
        }

        [Fact]
        public void FindMaxLevelNodes_MultipleLevelsWithSameMaxNodes_ReturnsSmallestLevel()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(7);
            Btree.Root.Left.Left.Left = new TNode(8);
            Btree.Root.Left.Right.Left = new TNode(9);
            Btree.Root.Right.Right.Left = new TNode(10);

            MaxLevelNodesClass analyzer = new MaxLevelNodesClass();

            // Act
            int result = analyzer.FindMaxLevelNodes(Btree.Root);

            // Assert
            Assert.Equal(2, result); 
        }

        [Fact]
        public void FindMaxLevelNodes_EmptyTree_ReturnsMinusOne()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(0); 
            Btree.Root = null; 

            MaxLevelNodesClass analyzer = new MaxLevelNodesClass();

            // Act
            int result = analyzer.FindMaxLevelNodes(Btree.Root);

            // Assert
            Assert.Equal(-1, result); 
        }
    }
}
