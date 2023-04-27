namespace Case2Aflevering
{
    internal class H1 : IHovedForløb
    {
        public Person[] Teachers { get; set; }
        public string[] Students { get; set; }
        public string[] Courses { get; set; }

        public H1()
        {

            Teachers = new Person[] // Et Array for lærer
            {
                new Person() {FirstName = "Niels", LastName = "Olesen"},
                new Person() {FirstName = "Flemming", LastName = "Sørensen"},
                new Person() {FirstName = "Peter", LastName = "Suni"}
               };
            Students = new string[0];
            Courses = new string[0];

        }
        
    }
}
