using System.Linq;
using System.Text;

namespace Day04
{
    public class RoomDescription
    {
        public RoomDescription(string name, int sectorId, string checksum)
        {
            Name = name;
            SectorId = sectorId;
            Checksum = checksum;
        }

        public string Name { get; private set; }

        public int SectorId { get; private set; }

        public string Checksum { get; set; }

        public bool Validate()
        {
            return CalculateChecksum().Equals(Checksum);
        }

        private string CalculateChecksum()
        {
            string calculatedChecksum = new string(
                Name.Where(x => x != '-')
                    .OrderBy(x => x)
                    .GroupBy(character => character, x => 1) // Map
                    .GroupBy(x => x.Key, x => x.Sum())  // Reduce
                    .OrderByDescending(x => x.Single())
                    .Take(5)
                    .Select(x => x.Key).ToArray());

            return calculatedChecksum;
        }

        public string Decrypt()
        {
            int shift = SectorId % 26;

            char[] buffer = Name.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];

                if (letter == '-')
                {
                    buffer[i] = ' ';
                    continue;
                }

                // Add shift to all.
                letter = (char)(letter + shift);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }

            return new string(buffer);
        }
    }
}