using Newtonsoft.Json.Linq;
using VogCodeChallenge.ConsoleApp;

namespace VogCodeChallenge.Test
{
    public class SWITCHModulesTest
    {
        [Theory]
        //A. int values of 1,2,3,4, multiply the provided value by 2 
        [InlineData(2, 4)]
        //B. int values bigger than 4, multiply the provided value by 3
        [InlineData(10, 30)]
        //D. float values 1.0f and 2.0f returns 3.0f
        [InlineData(2.0f, 3.0f)]
        //E. any string values convert to UpperCase
        [InlineData("myString", "MYSTRING")]
        //F. anything else return the input value
        [InlineData(true, true)]
        [InlineData('a', 'a')]
        public void SumOddNumbers_ReturnsSimillarValueType_WhenCalled(dynamic value1, dynamic expected)
        {
            var result = SWITCHModules.SWITCHModule(value1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SumOddNumbers_ThrowsException_WhenCalledWithNumberLowerThan1()
        {

            var ex = Assert.Throws<Exception>(() => SWITCHModules.SWITCHModule(-3));
            Assert.Contains("value below 1", ex.Message);

        }

    }
}