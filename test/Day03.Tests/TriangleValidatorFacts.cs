using Xunit;

namespace Day03.Tests
{
    public class TriangleValidatorFacts
    {
        public class TheValidateMethod
        {
            [Theory]
            [InlineData(5, 10, 25, false)]
            [InlineData(25, 5, 10, false)]
            [InlineData(10, 5, 25, false)]
            [InlineData(15, 10, 20, true)]
            public void Should_CheckIfSumOfAnyTwoEdgesIsGreaterThanTheRemainingEdge(int one, int two, int three, bool expected)
            {
                bool result = TriangleValidator.Validate(one, two, three);

                Assert.Equal(expected, result);
            }
        }
    }
}
