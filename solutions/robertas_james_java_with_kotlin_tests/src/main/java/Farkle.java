import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Farkle {

    private static List<FarkleScore> farkleScores = new ArrayList<>();

    static {
        farkleScores.add(new FarkleScore(1, 100, 900));
        farkleScores.add(new FarkleScore(2, 0, 200));
        farkleScores.add(new FarkleScore(3, 0, 300));
        farkleScores.add(new FarkleScore(4, 0, 400));
        farkleScores.add(new FarkleScore(5, 50, 450));
        farkleScores.add(new FarkleScore(6, 0, 600));
    }

    public static int roll(Integer... scores) {
        List<Integer> scoreList = Arrays.asList(scores);
        int score = 0;
        for (FarkleScore f: farkleScores) {
            score += getFarkleScoreForDie(f.getDiceScore(), f.getScoreForOne(), f.getScoreForThree(), scoreList);
        }
        return score;
    }

    private static boolean has(int count, int diceScore, List<Integer> scores) {
        return scores.stream()
                .filter(d -> d == diceScore)
                .count() >= count;
    }

    private static int getFarkleScoreForDie(int dieScore, int scoreForOne, int scoreForThree, List<Integer> scores) {
        int result = 0;
        if (scores.contains(dieScore)) {
            result += scoreForOne;
            if (has(3, dieScore, scores))
                result += scoreForThree;
            if (has(4, dieScore, scores))
                result += scores.size() > 5 ? scoreForOne + scoreForThree : scoreForOne;
            if (fiveOfAKindWithSixDices(dieScore, scores))
                result += result;
            if (sixOfAKindWithSixDiceses(dieScore, scores))
                result += result;
        }
        return result;
    }

    private static boolean sixOfAKindWithSixDiceses(int diceScore, List<Integer> scores) {
        return has(6, diceScore, scores) && scores.size() > 5;
    }

    private static boolean fiveOfAKindWithSixDices(int diceScore, List<Integer> scores) {
        return has(5, diceScore, scores) && scores.size() > 5;
    }
}
