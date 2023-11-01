using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_given_guess_number_and_secret_are_same()
        {
            // Given
            string secret = "1234";
            string guessNumber = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("5634")]
        [InlineData("5236")]
        [InlineData("1564")]
        public void Should_2A0B_when_guess_given_position_and_digit_partial_right(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1562")]
        public void Should_1A1B_when_guess_given_position_and_digit_partial_right(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("5678")]
        public void Should_0A0B_when_guess_given_all_digit_and_position_incorrect(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("4321")]
        public void Should_0A4B_when_guess_given_all_digit_correct_and_all_position_incorrect(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1243")]
        public void Should_2A2B_when_guess_given_all_digit_correct_and_position_partial_correct(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("2A2B", result);
        }

        [Theory]
        [InlineData("5612")]
        public void Should_0A2B_when_guess_given_digit_partial_correct_and_all_position_incorrect(string guessNumber)
        {
            // Given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            // When
            string result = game.Guess(guessNumber);

            // Then
            Assert.Equal("0A2B", result);
        }
    }
}
