namespace Day04
{
    public class RoomParser
    {
        public static RoomDescription GetRoomDescription(string input)
        {
            int checksumStart = input.IndexOf('[');

            string name = input.Substring(0, input.LastIndexOf('-'));
            int sectorId = int.Parse(input.Substring(name.Length + 1, 3));

            string checksum = input.Substring(checksumStart + 1, input.Length - input.IndexOf('[') - 2);

            return new RoomDescription(name, sectorId, checksum);
        }
    }
}