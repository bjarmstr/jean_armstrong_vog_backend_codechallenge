using VogCodeChallenge.ConsoleApp;

namespace VogCodeChallenge.Test
{
    public class OddNumberTest
    {
        [Fact]
        public void SumOddNumbers_ReturnsSumOfOddNumbers0To100_WhenCalled()
        {
            var result = OddNumbers.SumOddNumbers();

            Assert.Equal(2500, result);
        }
    }
}