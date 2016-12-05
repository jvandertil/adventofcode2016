using Xunit;

namespace Day04.Tests
{
    public class RoomParserFacts
    {
        public class GetRoomDescription
        {
            private static readonly string[] Inputs =
            {
                "aaaaa-bbb-z-y-x-123[abxyz]",
                "a-b-c-d-e-f-g-h-987[abcde]",
                "not-a-real-room-404[oarel]",
                "totally-real-room-200[decoy]"
            };

            [Theory]
            [InlineData(0, "aaaaa-bbb-z-y-x")]
            [InlineData(1, "a-b-c-d-e-f-g-h")]
            [InlineData(2, "not-a-real-room")]
            [InlineData(3, "totally-real-room")]
            public void Should_ExtractRoomName(int index, string expected)
            {
                var room = RoomParser.GetRoomDescription(Inputs[index]);

                Assert.Equal(expected, room.Name);
            }

            [Theory]
            [InlineData(0, 123)]
            [InlineData(1, 987)]
            [InlineData(2, 404)]
            [InlineData(3, 200)]
            public void Should_ExtractSectorId(int index, int expected)
            {
                var room = RoomParser.GetRoomDescription(Inputs[index]);

                Assert.Equal(expected, room.SectorId);
            }

            [Theory]
            [InlineData(0, "abxyz")]
            [InlineData(1, "abcde")]
            [InlineData(2, "oarel")]
            [InlineData(3, "decoy")]
            public void Should_ExtractChecksum(int index, string expected)
            {
                var room = RoomParser.GetRoomDescription(Inputs[index]);

                Assert.Equal(expected, room.Checksum);
            }
        }
    }
}
