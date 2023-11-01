using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly SecretGenerator secretGenerator;
        private readonly string secret;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = this.secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int bulls = 0;
            int cows = 0;
            if (guess.Equals(secret))
            {
                return "4A0B";
            }

            for (int i = 0; i < guess.Length; i++)
            {
                if (secret.IndexOf(guess[i]) == i)
                {
                    bulls++;
                }
            }

            for (int i = 0; i < guess.Length; i++)
            {
                if ((secret.IndexOf(guess[i]) != i) && (secret.IndexOf(guess[i]) >= 0))
                {
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}