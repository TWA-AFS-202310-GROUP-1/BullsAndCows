using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Theory]
        [InlineData("1234")]
        public void Should_return_4A0B_when_guess_given_all_values_and_positions_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("7834")]
        [InlineData("1935")]
        [InlineData("0274")]
        public void Should_return_2A0B_when_guess_given_partial_values_correct_and_all_positions_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1652")]
        [InlineData("9174")]
        [InlineData("2538")]
        public void Should_return_1A1B_when_guess_given_partial_values_correct_and_partial_positions_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("7890")]
        public void Should_return_0A0B_when_guess_given_everything_incorrect(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("2341")]
        [InlineData("3412")]
        public void Should_return_0A4B_when_guess_given_all_values_correct_and_all_positions_incorrect(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1324")]
        [InlineData("1432")]
        public void Should_return_2A2B_when_guess_given_all_values_correct_but_partial_positions_incorrect(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("2A2B", result);
        }

        [Theory]
        [InlineData("5643")]
        [InlineData("3197")]
        public void Should_return_0A2B_when_guess_given_partial_values_correct_but_all_positions_incorrect(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(x => x.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);

            //when
            string result = game.Guess(guessNumber);

            //then
            Assert.Equal("0A2B", result);
        }
    }
}
