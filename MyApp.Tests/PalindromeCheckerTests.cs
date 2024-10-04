using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    [TestFixture]
    public class PalindromeCheckerTests
    {
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            var input = "";
            var palindromeChecker = new PalindromeChecker();

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_SingleCharacterString_ReturnsTrue()
        {
            // Arrange
            var input = "a";
            var palindromeChecker = new PalindromeChecker();

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            // Arrange
            var input = "madam";
            var palindromeChecker = new PalindromeChecker();

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            // Arrange
            var input = "hello";
            var palindromeChecker = new PalindromeChecker();

            // Act
            var result = palindromeChecker.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_NullString_ThrowsArgumentNullException()
        {
            // Arrange
            string input = null;
            var palindromeChecker = new PalindromeChecker();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => palindromeChecker.IsPalindrome(input));
        }
    }

    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var left = 0;
            var right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
