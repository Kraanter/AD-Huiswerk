using NUnit.Framework;

namespace AD
{
    [TestFixture]
    public partial class BracketCheckerTests
    {
        [Test]
        public void BracketChecker1_1_EmptyString()
        {
            // Arrange
            string str = "";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BracketChecker1_2_SingleParentheses()
        {
            // Arrange
            string str = "()";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BracketChecker1_3_MultipleParentheses()
        {
            // Arrange
            string str = "((())())";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BracketChecker1_4_TooManyOpeningParentheses()
        {
            // Arrange
            string str = "((())((()))";
            bool expected = false;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BracketChecker1_5_TooManyClosingParentheses()
        {
            // Arrange
            string str = "((())()))";
            bool expected = false;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BracketChecker1_6_NumbersOkButTooManyClosing()
        {
            // Arrange
            string str = "(()))(";
            bool expected = false;

            // Act
            bool actual = BracketChecker.CheckBrackets(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_1_EmptyString()
        {
            // Arrange
            string str = "";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_2_Curly()
        {
            // Arrange
            string str = "{{}}";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_3_Brackets()
        {
            // Arrange
            string str = "[[]]";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_4_Combined1()
        {
            // Arrange
            string str = "[{()}]";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_5_Combined2()
        {
            // Arrange
            string str = "[(({[]}))]";
            bool expected = true;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_6_Combined3()
        {
            // Arrange
            string str = "[{(([))]}]";
            bool expected = false;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

         [Test]
        public void BracketChecker2_7_Combined4()
        {
            // Arrange
            string str = "[[[{{(}}]]])";
            bool expected = false;

            // Act
            bool actual = BracketChecker.CheckBrackets2(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

   }
}