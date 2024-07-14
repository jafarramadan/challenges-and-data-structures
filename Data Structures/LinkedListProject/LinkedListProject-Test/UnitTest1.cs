using Xunit;
using LinkedListProject;
namespace LinkedListProject_Test
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void RemoveDuplicates_NoDuplicates_ShouldRemainUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Act
            list.RemoveDuplicate();

            // Assert
            string expected = "Head -> 5 -> 10 -> 20 -> Null\r\n";
            Assert.Equal(expected, CaptureConsoleOutput(list.PrintList));
        }

        [Fact]
        public void RemoveDuplicates_WithDuplicates_ShouldRemoveDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            // Act
            list.RemoveDuplicate();

            // Assert
            string expected = "Head -> 5 -> 20 -> 10 -> Null\r\n";
            Assert.Equal(expected, CaptureConsoleOutput(list.PrintList));
        }

        [Fact]
        public void RemoveDuplicates_AllDuplicates_ShouldReduceToSingleElement()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);

            // Act
            list.RemoveDuplicate();

            // Assert
            string expected = "Head -> 7 -> Null\r\n";
            Assert.Equal(expected, CaptureConsoleOutput(list.PrintList));
        }

        
        private string CaptureConsoleOutput(Action action)
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                action.Invoke();
                return sw.ToString();
            }
        }
    }
}