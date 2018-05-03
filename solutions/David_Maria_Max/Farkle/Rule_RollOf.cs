namespace Farkle
{
    public enum LotsOf
    {
        Ones = 1,
        Twos = 2,
        Threes = 3,
        Fours = 4,
        Fives = 5,
        Sixes = 6
    }

    class Rule_RollOf
    {
        public int Quantity;
        public int NumberOfSpots;
        public int Score;

        public Rule_RollOf(int quantity, LotsOf numberOfSpots, int Scores)
        {
            this.Quantity = quantity;
            this.NumberOfSpots = (int)numberOfSpots;
            this.Score = Scores;
        }

        public (int[] remainingDice, int score) Apply(int[] numberOf, int currentScore)
        {
            var totalScore = currentScore;
            while (numberOf[this.NumberOfSpots] >= this.Quantity)
            {
                numberOf[this.NumberOfSpots] -= this.Quantity;
                totalScore += this.Score;
            }
            return (numberOf, totalScore);
        }
    }
}
