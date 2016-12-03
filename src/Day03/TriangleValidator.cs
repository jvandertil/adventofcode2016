namespace Day03
{
    public static class TriangleValidator
    {
        public static bool Validate(int one, int two, int three)
        {
            return (one + two) > three
                   && (one + three) > two
                   && (two + three) > one;
        }
    }
}