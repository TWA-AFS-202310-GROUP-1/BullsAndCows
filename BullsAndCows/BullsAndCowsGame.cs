using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly string secret;
        private readonly SecretGenerator secretGenerator;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            if (guess.Equals(secret))
            {
                return "4A0B";
            }

            return string.Empty;
        }
    }
}