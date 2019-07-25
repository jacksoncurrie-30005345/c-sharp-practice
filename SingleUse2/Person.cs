namespace SingleUse2
{
    class Person
    {
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        public int Age { get; protected set; }

        public Person(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;
        }

        public string GetName() => $"{Fname} {Lname}";
        public void HasBirthday() => Age++;
    }
}
