using System;

namespace SingleUse2
{
    class Program
    {
        static void Main()
        {
            Student billy = new Student("Billy", "Simpson", 36, "1003004");

            Console.WriteLine(Messages.Introduction, billy.GetName());
            Console.WriteLine(Messages.Age, billy.Age);
            billy.HasBirthday();
            Console.WriteLine(Messages.Age, billy.Age);
            Console.WriteLine(Messages.StudentId, billy.StudentId);
        }
    }
}
