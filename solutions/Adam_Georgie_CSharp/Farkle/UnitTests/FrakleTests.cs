using Xunit;

namespace CSharpTemplate.UnitTests
{
    public class FrakleTests
    {
        [Fact]
        public void Zero_score()
        {
            Assert.Equal(0, Frakle.Score(new[] { 2, 3, 4, 6, 2 }));
        }

        [Fact]
        public void Tripple_And_Five()
        {
            Assert.Equal(350, Frakle.Score(new[] { 3, 4, 5, 3, 3 }));
        }

        [Fact]
        public void Two_fives()
        {
            Assert.Equal(100, Frakle.Score(new[] { 5, 5, 3, 4, 2 }));
        }

        [Fact]
        public void Triple_fives()
        {
            Assert.Equal(500, Frakle.Score(new[] { 5, 2, 5, 3, 5 }));
        }

        [Fact]
        public void Four_fives()
        {
            Assert.Equal(1000, Frakle.Score(new[] { 5, 5, 5, 3, 5 }));
        }
    
        [Fact]
        public void Five_fives()
        {
            Assert.Equal(2000, Frakle.Score(new[] { 5, 5, 5, 5, 5 }));
        }

        [Fact]
        public void One_two_is_zero()
        {
            Assert.Equal(0, Frakle.Score(new[] { 2,3,3,4,4}));
        }

        [Fact]
        public void Three_two_is_two_hundred()
        {
            Assert.Equal(200, Frakle.Score(new[] { 2, 2, 2, 4, 4 }));
        }

        [Fact]
        public void Single_One()
        {
            Assert.Equal(100, Frakle.Score(new[] { 1, 2, 4, 6, 3 }));
        }

        [Fact]
        public void Triple_ones_is_1000()
        {
            Assert.Equal(1000, Frakle.Score(new[] { 1, 1, 1, 4, 3 }));
        }

        [Fact]
        public void Four_ones_is_1100()
        {
            Assert.Equal(2000, Frakle.Score(new[] { 1, 1, 1, 1, 4 }));
        }

        [Fact]
        public void Five_ones_is_1200()
        {
            Assert.Equal(4000, Frakle.Score(new[] { 1, 1, 1, 1, 1 }));
        }

        [Fact]
        public void Four_ones_One_Five_is_1150()
        {
            Assert.Equal(2050, Frakle.Score(new[] { 1, 1, 1, 5, 1 }));
        }

        [Fact]
        public void Triple_Fours_is_400()
        {
            Assert.Equal(400, Frakle.Score(new[] { 4, 4, 4, 3, 2 }));
        }

        [Fact]
        public void Triple_Sixes_is_600()
        {
            Assert.Equal(600, Frakle.Score(new[] { 6,6,6, 3, 2 }));
        }

        [Fact]
        public void Triple_Two_With_Five_And_One_is_350()
        {
            Assert.Equal(350, Frakle.Score(new[] { 2, 2, 2, 5, 1 }));
        }

        [Fact]
        public void One_one()
        {
            Assert.Equal(100, Frakle.Score(new[] { 1 }));
        }

        [Fact]
        public void Four_of_a_kind_for_twos_is_400()
        {
            Assert.Equal(400, Frakle.Score(new[] { 2,2,2,2 }));
        }
    }
}
