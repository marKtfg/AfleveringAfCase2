namespace Case2Aflevering
{
    internal class Person : IComparable<Person>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int CompareTo(Person? other)
        {
            if (other != null)
            {
                return string.Compare(FirstName, other.FirstName);
            }
            else
                return 0;
        }
    }
}
