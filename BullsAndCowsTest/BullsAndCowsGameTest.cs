using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        //[Fact]
        //public void Should_create_BullsAndCowsGame()
        //{
        //    var secretGenerator = new SecretGenerator();
        //    var game = new BullsAndCowsGame(secretGenerator);
        //    Assert.NotNull(game);
        //    Assert.True(game.CanContinue);
        //}

        [Theory]
        [InlineData("1234")]
        public void Should_return_4A0B_when_guess_number_and_secret_are_same(string guessNumber)
        {
            //Given
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
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
        public void Should_return_2A0B_when_guess_position_and_digit_partial_right(string guessNumber)
        {
            //Given
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1562")]
        public void Should_return_1A1B_when_guess_position_and_value_partial_correct(string guessNumber)
        {
            //Given
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("5678")]
        public void Should_return_0A0B_when_guess_position_and_value_all_incorrect(string guessNumber)
        {
            //Given
            string secretNumber = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secretNumber);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            //When
            string result = game.Guess(guessNumber);
            //Then
            Assert.Equal("0A0B", result);
        }
    }
}
