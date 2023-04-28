namespace Case2Aflevering
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        void Hello();
    }

    class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name)
        {
            Name = name;
        }
        public void Hello()
        {
            Console.WriteLine("Hej, jeg er elev og mit navn er " + Name);
        }
    }

    class Teacher : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Teacher(string name, string course)
        {
            Name = name;
            Course = course;
        }

        public void Hello()
        {
            Console.WriteLine("Hej, jeg underviser i " + Course + " og mit navn er " + Name);
        }
    }
}
