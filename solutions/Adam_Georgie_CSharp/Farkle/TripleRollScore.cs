using System.Collections.Generic;

namespace CSharpTemplate
{
    internal partial class Frakle
    {

        private class TripleRollScore
        {
            public static readonly List<TripleRollScore> TripleRollScores = new List<TripleRollScore>()
            {
                new TripleRollScore(1, 1000),
                new TripleRollScore(2, 200),
                new TripleRollScore(3, 300),
                new TripleRollScore(4, 400),
                new TripleRollScore(5, 500),
                new TripleRollScore(6, 600),
            };

            private TripleRollScore(int roll, int score)
            {
                Roll = roll;
                Score = score;
            }
            public int Roll { get; }
            public int Score { get; }
        }
    }
}