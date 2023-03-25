namespace NumSetLibrary
{
    public class NumSet : IEquatable<NumSet>
    {
        private readonly HashSet<int> _numbers;

        public NumSet(params int[] numbers)
        {
            _numbers = new HashSet<int>(numbers);
        }

        override
        public string ToString()
        {
            return string.Join(", ", _numbers);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as NumSet);
        }

        public bool Equals(NumSet? other)
        {
            return other != null && _numbers.SetEquals(other._numbers);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            foreach (var num in _numbers)
            {
                hash = hash * 23 + num.GetHashCode();
            }
            return hash;
        }

        public static bool operator ==(NumSet? left, NumSet? right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (left is null || right is null)
            {
                return false;
            }
            return left.Equals(right);
        }

        public static bool operator !=(NumSet? left, NumSet? right)
        {
            return !(left == right);
        }

        public int[] ToArray()
        {
            return _numbers.ToArray();
        }
        public static implicit operator int[](NumSet? set)
        {
            return set?.ToArray() ?? Array.Empty<int>();
        }

    }
}

