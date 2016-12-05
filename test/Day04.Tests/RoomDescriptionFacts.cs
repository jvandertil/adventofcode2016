using System;
using Xunit;

namespace Day04.Tests
{
    public class RoomDescriptionFacts
    {
        public class TheValidateMethod
        {
            private static readonly string[] Inputs =
            {
                "aaaaa-bbb-z-y-x-123[abxyz]",
                "a-b-c-d-e-f-g-h-987[abcde]",
                "not-a-real-room-404[oarel]",
                "totally-real-room-200[decoy]"
            };

            [Theory]
            [InlineData(0, true)]
            [InlineData(1, true)]
            [InlineData(2, true)]
            [InlineData(3, false)]
            public void Should_ValidateTheNameWithTheChecksum(int index, bool valid)
            {
                var room = RoomParser.GetRoomDescription(Inputs[index]);

                Assert.Equal(valid, room.Validate());
            }
        }

        public class TheDecryptMethod
        {
            private static readonly string[] Inputs =
            {
                "qzmt-zixmtkozy-ivhz-343[abcde]" // Checksum not used now.
            };

            [Theory]
            [InlineData(0, "very encrypted name")]
            public void Should_DecryptTheNameUsingTheSectorId(int index, string decrypted)
            {
                var room = RoomParser.GetRoomDescription(Inputs[index]);

                Assert.Equal(decrypted, room.Decrypt());
            }
        }
    }
}