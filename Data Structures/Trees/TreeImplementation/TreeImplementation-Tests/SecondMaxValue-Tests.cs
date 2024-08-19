using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.SecondMaxValue;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class SecondMaxValue_Tests
    {
        [Fact]
        public void FindSecondMax_ShouldReturnSecondMaximumValue_InBinaryTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);
            Btree.insert(5);
            Btree.insert(20);
            Btree.insert(3);
            Btree.insert(7);
            Btree.insert(15);
            Btree.insert(25);
            SecondMaxValueClass secondMaxFinder = new SecondMaxValueClass();

            // Act
            int secondMax = secondMaxFinder.FindSecondMax(Btree.Root);

            // Assert
            Assert.Equal(20, secondMax);
        }
        [Fact]
        public void FindSecondMax_ShouldThrowException_WhenTreeHasFewerThanTwoUniqueValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);
            Btree.insert(10);
            SecondMaxValueClass secondMaxFinder = new SecondMaxValueClass();

            // Act & Assert
            int secondMax = secondMaxFinder.FindSecondMax(Btree.Root);
            Assert.Equal(10, secondMax);
        }
        [Fact]
        public void FindSecondMax_ShouldReturnSecondMaximumValue_InBinaryTreeWithNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(-10);
            Btree.insert(-20);
            Btree.insert(-5);
            Btree.insert(-15);
            Btree.insert(-7);
            Btree.insert(-25);
            Btree.insert(-1);
            SecondMaxValueClass secondMaxFinder = new SecondMaxValueClass();

            // Act
            int secondMax = secondMaxFinder.FindSecondMax(Btree.Root);

            // Assert
            Assert.Equal(-5, secondMax);
        }
    }
}
