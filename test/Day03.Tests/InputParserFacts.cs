using System.Linq;
using Xunit;

namespace Day03.Tests
{
    public class InputParserFacts
    {
        public class TheParseRowsMethod
        {
            [Fact]
            public void Should_ReturnValuesInCorrectOrder()
            {
                string[] input =
                {
                    "  330  143  338",
                    "  769  547   83",
                    "  930  625  317"
                };

                int[] expected = { 330, 143, 338, 769, 547, 83, 930, 625, 317 };

                int[] result = InputParser.ParseRows(input);

                Assert.True(expected.SequenceEqual(result));
            }
        }

        public class TheParseColumnsMethod
        {
            [Fact]
            public void Should_ReturnValuesInCorrectOrder()
            {
                string[] input =
                {
                    "  330  143  338",
                    "  769  547   83",
                    "  930  625  317"
                };

                int[] expected = { 330, 769, 930, 143, 547, 625, 338, 83, 317 };

                int[] result = InputParser.ParseColumns(input);

                Assert.True(expected.SequenceEqual(result));
            }
        }
    }
}