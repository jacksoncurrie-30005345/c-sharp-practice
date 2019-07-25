namespace SingleUse2
{
    class Student : Person
    {
        public string StudentId { get; protected set; }

        public Student(string fname, string lname, int age, string studentid) : base(fname, lname, age)
        {
            StudentId = studentid;
        }
    }
}
