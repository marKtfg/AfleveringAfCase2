namespace Case2Aflevering
{
    internal class Mark
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _middleName;
        public Mark(string firstname, string middleName, string lastname)
        {
            FirstName = firstname;
            _middleName = middleName;
            LastName = lastname;

            //if (Utility.IsOnline())
            //{
            //    // Gør noget online her...
            //}
        }
        private void SetMiddleName(string middleName)
        {
            _middleName = middleName;
        }
        //public void GetMiddleName()
        //{
        //    return _middleName;
        //}
        //Alt inde i en class kaldes en ''member'' det vil sige at ''public void showtext'' er en member

        public void ShowText()
        {
            Console.WriteLine($"Hello {FirstName} {LastName} !");
        }
        public string ShowText2()
        {
            return ($"Hello {FirstName} {_middleName} {LastName} !");
        }

    }
}
