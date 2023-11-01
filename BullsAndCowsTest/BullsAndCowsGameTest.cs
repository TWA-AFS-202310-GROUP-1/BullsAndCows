using BullsAndCows;
using Moq;
using System.Net.Sockets;
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

        [Fact]
        public void Should_return_4A0B_when_guess_given_all_digits_are_correct()
        {
            string guessNumber = "1234";
            string secret = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(s => s.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            string result = game.Guess(guessNumber);
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("1564")]
        [InlineData("5236")]
        [InlineData("5634")]
        public void Should_return_2A0B_when_guess_given_digits_position_partitial_right(string guessNumber)
        {
            string secret = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(s => s.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            string result = game.Guess(guessNumber);
            Assert.Equal("2A0B", result);
        }

        [Fact]
        public void Should_return_0A0B_when_guess_given_digits_position_all_wrong()
        {
            string guessNumber = "5678";
            string secret = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(s => s.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            string result = game.Guess(guessNumber);
            Assert.Equal("0A0B", result);

        }

        [Fact]
        public void Should_return_0A4B_when_guess_given_digits_correct_position_wrong()
        {
            string guessNumber = "4321";
            string secret = "1234";
            Mock<SecretGenerator> mockedSecretGenerator = new Mock<SecretGenerator>();
            mockedSecretGenerator.Setup(s => s.GenerateSecret()).Returns(secret);
            var game = new BullsAndCowsGame(mockedSecretGenerator.Object);
            string result = game.Guess(guessNumber);
            Assert.Equal("0A4B", result);
        }

    }
}
