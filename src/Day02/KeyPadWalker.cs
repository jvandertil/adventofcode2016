using System;

namespace Day02
{
    public class KeyPadWalker
    {
        private readonly string[][] _keyPad;
        private readonly Position _startPosition;
        private readonly string _edgeIndicator;

        public KeyPadWalker(string[][] keyPad, Position startPosition, string edgeIndicator = null)
        {
            _keyPad = keyPad;
            _startPosition = startPosition;
            _edgeIndicator = edgeIndicator;
        }

        public string WalkKeyPad(string[] input)
        {
            var position = _startPosition;

            string result = string.Empty;

            for (int i = 0; i < input.Length; ++i)
            {
                foreach (char instruction in input[i])
                {
                    Position newPosition;

                    switch (instruction)
                    {
                        case 'U':
                            newPosition = position.GoUp();
                            break;

                        case 'D':
                            newPosition = position.GoDown();
                            break;

                        case 'L':
                            newPosition = position.GoLeft();
                            break;

                        case 'R':
                            newPosition = position.GoRight();
                            break;

                        default:
                            throw new Exception($"Can not process {instruction}.");
                    }

                    if (GetPositionValue(newPosition) != _edgeIndicator)
                    {
                        position = newPosition;
                    }
                }

                result += GetPositionValue(position);
            }

            return result;
        }

        private string GetPositionValue(Position position)
        {
            return _keyPad[position.Y][position.X];
        }
    }
}