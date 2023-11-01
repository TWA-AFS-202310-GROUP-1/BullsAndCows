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
            int Anum = 0;
            int Bnum = 0;
            for(int i = 0; i<4; i++) {
                if (guess[i] == Secret[i])
                {
                    Anum++;
                }
                else if (Secret.Contains(guess[i]))
                {
                    Bnum++;
                }
            }            
            return  Anum.ToString() +"A" + Bnum.ToString() + "B";
        }
    }
}