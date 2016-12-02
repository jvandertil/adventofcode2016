using Xunit;

namespace Day02.Tests
{
    public class KeyPadWalkerFacts
    {
        public class TheWalkKeyPadMethod
        {
            private readonly string[] _input =
            {
                "ULL",
                "RRDDD",
                "LURDL",
                "UUUUD"
            };

            [Fact]
            public void Should_SolvePartOneExample()
            {
                var walker = new KeyPadWalker(KeyPads.PartOneKeyPad, new Position(1, 1, 0, 2), null);

                string solution = walker.WalkKeyPad(_input);

                Assert.Equal("1985", solution);
            }

            [Fact]
            public void Should_SolvePartTwoExample()
            {
                var walker = new KeyPadWalker(KeyPads.PartTwoKeyPad, new Position(0, 2, 0, 4), null);

                string solution = walker.WalkKeyPad(_input);

                Assert.Equal("5DB3", solution);
            }
        }
    }
}
