using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        [Test]
        public void IsPalindrome_WhenStringIsPalindrome_ReturnsTrue()
        {
            // Arrange
            var palindromeChecker = new PalindromeChecker();
            var input = "madam";

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WhenStringIsNotPalindrome_ReturnsFalse()
        {
            // Arrange
            var palindromeChecker = new PalindromeChecker();
            var input = "hello";

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_WhenStringIsEmpty_ReturnsTrue()
        {
            // Arrange
            var palindromeChecker = new PalindromeChecker();
            var input = "";

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WhenStringHasSingleCharacter_ReturnsTrue()
        {
            // Arrange
            var palindromeChecker = new PalindromeChecker();
            var input = "a";

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WhenStringHasSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            var palindromeChecker = new PalindromeChecker();
            var input = "A man, a plan, a canal: Panama";

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
