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
            //Given
            string guessNumber = "1234";
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("5634")]
        [InlineData("5236")]
        [InlineData("1564")]
        public void Should_return_2A0B_when_guess_given_guess_number_and_secret_are_partial_right(string guessNumber)
        {
            //Given
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1562")]
        public void Should_return_1A1B_when_guess_given_guess_number_and_secret_are_partial_right(string guessNumber)
        {
            //Given
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("5678")]
        public void Should_return_0A0B_when_guess_given_guess_number_and_secret_are_all_wrong(string guessNumber)
        {
            //Given
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("4321")]
        public void Should_return_0A4B_when_guess_given_guess_number_and_secret_are_all_right_and_position_all_wrong(string guessNumber)
        {
            //Given
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1243")]
        public void Should_return_2A2B_when_guess_given_guess_number_and_secret_are_partial_right(string guessNumber)
        {
            //Given
            string secret = "1234";
            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A2B", result);
        }
    }
}
