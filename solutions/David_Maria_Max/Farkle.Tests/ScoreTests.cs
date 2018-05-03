using Xunit;

namespace Farkle.Tests
{
    public class ScoreTests
    {
        [Fact]
        public void Given_12346_The_Score_Should_be_100()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 1, 2, 3, 4, 6 });

            Assert.Equal(100, actualResult);
        }
        [Fact]
        public void Given_5_The_Score_Should_be_50()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 5, 2, 3, 4, 6 });

            Assert.Equal(50, actualResult);
        }

        [Fact]
        public void Given_5_Anywhere_The_Score_Should_be_50()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 3, 4, 6, 5 });

            Assert.Equal(50, actualResult);
        }

        [Fact]
        public void Given_Three_Lots_Of_One_The_Score_Should_be_1000()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 1, 1, 4, 1 });

            Assert.Equal(1000, actualResult);
        }

        [Fact]
        public void Given_Three_Lots_Of_Two_The_Score_Should_be_200()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 2, 2, 4, 3 });

            Assert.Equal(200, actualResult);
        }
        [Fact]
        public void Given_Three_Lots_Of_Trees_The_Score_Should_be_300()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 3, 2, 3, 4, 3 });

            Assert.Equal(300, actualResult);
        }

        [Fact]
        public void Given_Three_Lots_Of_Four_The_Score_Should_be_400()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 3, 4, 4, 4, 3 });

            Assert.Equal(400, actualResult);
        }

        [Fact]
        public void Given_Three_Lots_Of_Five_The_Score_Should_be_500()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 5, 5, 5, 2 });

            Assert.Equal(500, actualResult);
        }

        [Fact]
        public void Given_Three_Lots_Of_Six_The_Score_Should_be_600()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 6, 6, 6, 2 });

            Assert.Equal(600, actualResult);
        }

        [Fact]
        public void Given_11151_be_1150()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 1, 1, 1, 5, 1 });

            Assert.Equal(1150, actualResult);
        }

        [Fact]
        public void Given_23462_be_0()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 2, 3, 4, 6, 2 });

            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void Given_34533_be_350()
        {
            var score = new Scorer();
            var actualResult = score.Evaluate(new int[] { 3, 4, 5, 3, 3 });

            Assert.Equal(350, actualResult);
        }

        //[Fact]
        //public void Given_22226_be_400()
        //{
        //    var score = new Scorer();
        //    var actualResult = score.Evaluate(new int[] { 2, 2, 2, 2, 6 });

        //    Assert.Equal(400, actualResult);
        //}

    }
}