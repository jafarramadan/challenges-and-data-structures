using LinkedListProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject_Test
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void TestRotatByKEqualZero()
        {
            //arrange 
            LinkedList listK = new LinkedList();
            listK.Add(1);
            listK.Add(2);
            listK.Add(3);
            listK.Add(4);
            listK.Add(5);
            // Act
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                listK.RotateLeft(listK, 0);
                listK.PrintList();

                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("Head->1->2->3->4->5->Null", output);
            }
        }
        [Fact]
        public void TestRotatByKGreaterThanLength()
        {
            //arrange 
            LinkedList listK = new LinkedList();
            listK.Add(1);
            listK.Add(2);
            listK.Add(3);
            listK.Add(4);
            listK.Add(5);
            // Act
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                listK.RotateLeft(listK, 2);
                listK.PrintList();

                // Assert
                var output = stringWriter.ToString().Replace("\r\n", "");
                Assert.Equal("Head->2->3->4->5->1->Null", output);
            }
        }
    }
}
