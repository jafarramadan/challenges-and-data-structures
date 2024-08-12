using TreeImplementation;

namespace TreeImplementation_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.insert(5);
            b.insert(15);
            b.insert(2);
            b.insert(7);
            b.insert(12);
            b.insert(20);

            List<int> expectedOutput = new List<int> { 10, 5, 2, 7, 15, 12, 20 };
            List<int> actualOutput = new List<int>();

            // Inserting output
             void PreOrder(TNode node)
            {
                if (node == null) return;
                actualOutput.Add(node.Value);
                PreOrder(node.Left);
                PreOrder(node.Right);

            }

            // Act
            PreOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void InOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.insert(5);
            b.insert(15);
            b.insert(2);
            b.insert(7);
            b.insert(12);
            b.insert(20);

            List<int> expectedOutput = new List<int> { 2, 5, 7, 10, 12, 15, 20 };
            List<int> actualOutput = new List<int>();

            // Inserting output
            void InOrder(TNode node)
            {
                if (node == null) return;
                InOrder(node.Left);
                actualOutput.Add(node.Value);
                InOrder(node.Right);
            }

            // Act
            InOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);

        }
        [Fact]
        public void PostOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.insert(5);
            b.insert(15);
            b.insert(2);
            b.insert(7);
            b.insert(12);
            b.insert(20);

            List<int> expectedOutput = new List<int> { 2, 7, 5, 12, 20, 15, 10 };
            List<int> actualOutput = new List<int>();

            // Inserting output
            void PostOrder(TNode node)
            {
                if (node == null) return;
                PostOrder(node.Left);
                PostOrder(node.Right);
                actualOutput.Add(node.Value);
            }

            // Act
            PostOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);

        }
    }
}