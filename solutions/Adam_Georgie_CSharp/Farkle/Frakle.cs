using System.Collections.Generic;
using System.Linq;

namespace CSharpTemplate
{
    internal partial class Frakle
    {
        public static int Score(int[] rolls)
        {
            return ApplyScores(rolls).Sum();
        }

        private static IEnumerable<int>  ApplyScores(int[] rolls)
        {
            foreach (var rollScore in TripleRollScore.TripleRollScores)
            {
                yield return ScoreTriples(rolls, rollScore.Roll, rollScore.Score);
            }

            yield return ScoreSingles(rolls, 1, 100);
            yield return ScoreSingles(rolls, 5, 50);
        }

        private static int ScoreTriples(int[] rolls, int value, int score)
        {
            int rollCount = rolls.Count(roll => roll == value);

            if (rollCount == 3)
            {
                return score;
            }
            if (rollCount > 3)
            {
                return MoreThanThreeTripleMultiplier(score, rollCount);
            }

            return 0;
        }

        private static int MoreThanThreeTripleMultiplier(int score, int rollCount)
        {
            return (rollCount - 3) * score * 2;
        }

        private static int ScoreSingles(int[] rolls, int rollValue, int rollScore)
        {
            int rollCount = rolls.Count(roll => roll == rollValue);

            switch (rollCount)
            {
                case 1:
                case 2:
                    return rollCount * rollScore;
                default:
                    return 0;
            }
        }
    }
}