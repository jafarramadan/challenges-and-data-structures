using Xunit;
using LinkedListProject;
namespace LinkedListProject_Test
{
    public class LinkedListImplementaionTests
    {
        [Fact]
        public void Remove_NodeFromEnd_ShouldRemoveNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Act
            list.Remove(20);

            // Assert
            Assert.False(list.Includes(20));
        }

        [Fact]
        public void PrintList_ShouldPrintCorrectContents()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Redirect console output
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);

                // Act
                list.PrintList();

                // Assert
                string expected = "Head -> 5 -> 10 -> 20 -> Null\r\n";
                Assert.Equal(expected, sw.ToString());
            }
        }

        [Fact]
        public void Remove_NodeNotInList_ShouldThrowException()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.Remove(30));
        }

        [Fact]
        public void Remove_NodeFromEmptyList_ShouldThrowException()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => list.Remove(10));
        }
    }
}