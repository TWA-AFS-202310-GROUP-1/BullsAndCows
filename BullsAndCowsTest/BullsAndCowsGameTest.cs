using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            var secretGenerator = new SecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void Should_return_4A0B_when_guess_number_and_secret_are_same()
        {
            //Given
            string guessNumber = "1234";
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("4A0B", result);
        }

        [Fact]
        public void Should_return_2A0B_when_guess_position_and_digit_partial_right()
        {
            //Given
            string guessNumber = "1256";
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A0B", result);
        }

    }

}
