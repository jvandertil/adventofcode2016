using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02
{
    public static class KeyPads
    {
        public static readonly string[][] PartOneKeyPad =
        {
            new[] {"1", "2", "3"},
            new[] {"4", "5", "6"},
            new[] {"7", "8", "9"}
        };

        public static readonly string[][] PartTwoKeyPad =
        {
            new[] {null, null, "1", null, null},
            new[] {null, "2", "3", "4", null},
            new[] {"5", "6", "7", "8", "9"},
            new[] {null, "A", "B", "C", null},
            new[] {null, null, "D", null, null},
        };
    }
}