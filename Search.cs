namespace Case2Aflevering
{
    internal class Search
    {
        public string SomeText { get; set; }
        private readonly H1 _h1;

        public Search(H1 h1, string someText)
        {
            _h1 = h1;
            SomeText = someText;
        }
        public List<Person> GetTeachers()
        {
            Person pMatched = _h1.Teachers.FirstOrDefault(a => a.FirstName == "Niels")!;

            List<Person> P = _h1.Teachers.ToList();
            P.Sort();
            return P;
        } //System.Collections.Generic.List
    }
}
