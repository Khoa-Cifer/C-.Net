using StudentTesterV2.Entities;

namespace StudentTesterV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student an = new Student("SE1", "An Nguyen", "Check");
            Student an1 = new();
            //var an2 = new Student(); không chấp nhận do đã mất constructor default, class đã có constructor có tham số rồi
            Console.WriteLine("AN full Info: " + an.ToString());
        }
    }
}
