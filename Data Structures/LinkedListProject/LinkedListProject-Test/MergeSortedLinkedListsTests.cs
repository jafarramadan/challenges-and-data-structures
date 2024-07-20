using Xunit;
using LinkedListProject;
using System.Collections.Generic;
namespace LinkedListProject_Test
{
    public class MergeSortedLinkedListsTests
    {
        [Fact]
        public void OneListEmpty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(3);
            list2.Add(5);

            // Act
            LinkedList mergedList = list1.MergeSortedLists(list1, list2);
            var sw = new StringWriter();
            Console.SetOut(sw);
            mergedList.PrintList();
            string Actual = sw.ToString();

            // Assert
            Assert.Equal("Head->1->3->5->Null\r\n", Actual);
        }

        [Fact]
        public void BothListsEmpty()
        {
            //arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            //act
            LinkedList mergedList = list1.MergeSortedLists(list1, list2);

            //assert
            Assert.Equal(null, mergedList.Head);
            

        }

        [Fact]
        public void MergeTwoLists()
        {
            //arrange
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);
            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            //act
            LinkedList mergedList = list1.MergeSortedLists(list1, list2);
            var sw = new StringWriter();
            Console.SetOut(sw);
            mergedList.PrintList();
            string Actual = sw.ToString();

            //assert
            Assert.Equal("Head->2->3->5->10->15->20->Null\r\n", Actual);

        }
    }
}
