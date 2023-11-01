using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private string Secret { get; set; }
        private readonly SecretGenerator secretGenerator;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            Secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            if (Secret.Equals(guess))
            {
                return "4A0B";
            }
            return null;
        }
    }
}