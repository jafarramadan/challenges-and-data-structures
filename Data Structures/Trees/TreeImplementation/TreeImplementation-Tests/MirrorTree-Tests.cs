using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation.MirrorTree;
using TreeImplementation.TreeImplementation;

namespace TreeImplementation_Tests
{
    public class MirrorTreeTests
    {
        [Fact]
        public void TestMirrorTree_InorderTraversal()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(1);
            tree.insert(2);
            tree.insert(3);
            tree.insert(4);
            tree.insert(5);

            MirrorTreeClass mirrorTree = new MirrorTreeClass();

            // Act
            List<int> originalInorder = mirrorTree.InorderTraversal(tree.Root);
            List<int> mirroredInorder = mirrorTree.Merror(originalInorder);

            // Assert
            Assert.Equal(new List<int> { 5, 4, 3, 2, 1 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorTree_SingleNodeTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree(1);
            MirrorTreeClass mirrorTree = new MirrorTreeClass();

            // Act
            List<int> originalInorder = mirrorTree.InorderTraversal(tree.Root);
            List<int> mirroredInorder = mirrorTree.Merror(originalInorder);

            // Assert
            Assert.Equal(new List<int> { 1 }, mirroredInorder);
        }

    }
}
