using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_given_correct_number()
        {
            string guessNumber = "1234";
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            string result = game.Guess(guessNumber);
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("7834")]
        [InlineData("1935")]
        [InlineData("0274")]
        public void Should_return_2A0B_when_guess_given_partial_position_and_value_correct(string guessNumber)
        {
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            string result = game.Guess(guessNumber);
            Assert.Equal("2A0B", result);
        }
    }
}
