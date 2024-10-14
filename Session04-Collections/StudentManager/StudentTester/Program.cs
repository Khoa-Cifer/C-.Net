using StudentTester.Entities;
using StudentTester.Services;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Đi mua 2 cái tủ, 1 đựng student SE, 1 đựng student IA
            //Bên C: ta cần 4 biến, mảng student SE + count student SE,
            //mảng student IA + count student IA

            Cabinet tuSE = new(500);
            Cabinet tuIA = new(100);

            tuSE.AddStudent("SE1", "An Nguyen", 2004, 6.9);
            tuSE.AddStudent("SE2", "Binh Le", 2004, 6.9);
            tuSE.AddStudent("SE3", "Cuong Nguyen", 2004, 6.9);

            tuIA.AddStudent("SE4", "Y Nguyen", 2004, 6.9);
            tuSE.AddStudent("SE5", "X Nguyen", 2004, 6.9);

            tuIA.AddStudent(new Student() { Id = "SE6", Name = "Giang Ho", Yob = 2000, Gpa = 0.1 });

            Console.WriteLine("SE students:");
            tuSE.PrintStudentList();
            Console.WriteLine("IA students:");
            tuIA.PrintStudentList();

            tuSE.UpdateStudent("SE3", "Mr X", 123, 7.5);
            Console.WriteLine("Updating SE3");
            tuSE.PrintStudentList();
            Console.WriteLine("Delete SE3");
            tuSE.RemoveStudent("SE3");
            tuSE.PrintStudentList();
        }
    }
}
