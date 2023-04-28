namespace Case2Aflevering
{
    internal interface IHovedForløb
    {
        public IPerson[] Teachers { get; set; }
        public string[] Students { get; set; }
        public string[] Courses { get; set; }
    }
}
