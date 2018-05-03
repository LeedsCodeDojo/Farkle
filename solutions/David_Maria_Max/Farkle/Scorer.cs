using System.Collections.Generic;
using System.Linq;

namespace Farkle
{
    public class Scorer
    {
        public int Evaluate(int[] diceRolls)
        {
            var rules = new List<Rule_RollOf>()
            {
                new Rule_RollOf(3,LotsOf.Ones,Scores:1000),
                new Rule_RollOf(3,LotsOf.Twos,Scores:200),
                new Rule_RollOf(3,LotsOf.Threes,Scores:300),
                new Rule_RollOf(3,LotsOf.Fours,Scores:400),
                new Rule_RollOf(3,LotsOf.Fives,Scores:500),
                new Rule_RollOf(3,LotsOf.Sixes,Scores:600),
                new Rule_RollOf(1,LotsOf.Ones,Scores:100),
                new Rule_RollOf(1,LotsOf.Fives,Scores:50),
            };

            var numberOf = CountDice(diceRolls);
            var initialState = (RemainingDice: numberOf, RunningTotal: 0);
            var totalScore = rules.Aggregate(initialState,
                                             (state, rule) => rule.Apply(state.RemainingDice, state.RunningTotal)).RunningTotal;
            return totalScore;
        }

        private int[] CountDice(int[] diceRolls)
            => Enumerable.Range(0, 7).Select(numberOfSpots => NumberOfDice(diceRolls, numberOfSpots)).ToArray();

        private int NumberOfDice(int[] diceRolls, int numberOfSpots) => diceRolls.Count(roll => roll == numberOfSpots);
    }
}
