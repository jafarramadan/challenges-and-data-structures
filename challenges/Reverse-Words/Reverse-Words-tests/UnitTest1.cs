using Reverse_Words;

namespace Reverse_Words_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string input = "csharp is programming language";
            string output = "language programming is csharp";

            //Act
            string result=Program.ReverseWords(input);

            //Assert
            Assert.Equal(output, result);

        }

        [Fact]
        public void Test2()
        {
            //Arrange
            string input = "Reverse the words in this sentence";
            string output = "sentence this in words the Reverse";

            //Act
            string result = Program.ReverseWords(input);

            //Assert
            Assert.Equal(output, result);


        }

        [Fact]
        public void Test3()
        {
            //Arrange
            string input = "challenges and data structures";
            string output = "structures data and challenges";

            //Act
            string result = Program.ReverseWords(input);

            //Assert
            Assert.Equal(output, result);

        }
    }
}



