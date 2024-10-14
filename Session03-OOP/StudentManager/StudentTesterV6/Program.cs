using StudentTesterV6.Entities;

namespace StudentTesterV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student() { Id = "SE1", Name = "An Nguyen" };
            Console.WriteLine(an);
        }
    }
}
