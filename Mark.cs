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
        }
        private void SetMiddleName(string middleName)
        {
            _middleName = middleName;
        }
        public string GetMiddleName()
        {
            return _middleName;
        }
        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }
        
        //Alt inde i en class kaldes en ''member'' det vil sige at ''public void showtext'' er en member

        public string ShowText()
        {
            return ($"Hello {FirstName} {_middleName} {LastName}!");
        }

    }
}
