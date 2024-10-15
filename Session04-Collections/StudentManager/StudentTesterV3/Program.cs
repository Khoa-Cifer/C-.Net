using StudentTester.Entities;
using StudentTesterV3.Services;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //New 2 mảng int
            int[] a = { 1, 3, 5, 7, 9 }; //Mảng 5 phần tử, 5 kiểu int
            int[] b = { 5, 10, 15, 20, 25, 30 }; //mảng 8 phần tử
            //a = b, nghĩa là a cùng trỏ cùng new mà b đang trỏ
            //biến mảng là biến object giống như student
            //cho nên 2 biến object = nhau -> nghĩa là trỏ cùng
            a = b;
            Console.WriteLine("A SIZE", a.Length);
            Console.WriteLine(a[0]);
        }
        //CHơi với biến mảng cũng là chơi với biến object,
        //2 biến object bằng nhau thì trỏ cùng
        //BIến mảng truyền vào hàm, trong hàm cũng trỏ ra bên ngoài mảng gốc
        //Khi gọi hàm F(b) nghĩa là a = b, a trỏ cùng b ở bên ngoài hàm
        //Truyền biến object chính là truyền tham chiếu, trỏ cùng, pass by reference
        //Mảng có ưu và nhược như sau
        //Dễ hiểu, dễ dùng, [index]
        //Nhược điểm: bị fix kích thước, xin nhiêu có bao nhiêu, không thêm bớt được
        //Phải đi kèm biến count để ghi nhận số phần tử hiện tại đang có giá trị, và for đến count
        //Muốn thêm phần tử vào mảng, chỉ có cách new vùng mới
        //Nhưng khi đó data vùng cũ có thể bị mất, hoặc copy hết sang vùng mới
        //Không có xoá mảng, chỉ là đôn giá trị lên và trừ count đi
        //Vậy để fix cho những nhược điểm của mảng, java và c# chế ra các class phuc vụ cho nhu cầu lưu trữ nhiều data như mảng, nhưng tốt hơn mảng.
        //Những class này linh hoạt trong việc co giản kích thước, cần thêm chỗ phần tử thứ [i] thì cho thêm, xoá thì bớt luôn số phần tử đã xoá, ram có thể mở to, thu nhỏ
        //Các class này gọi là Collections


        static void PlayWithCabinetGeneric()
        {
            Cabinet<Student> tuSE = new Cabinet<Student>(500);
            tuSE.PrintList(); //Mua cái tủ về, mở ra xem, nhưng vẫn có không gian (500)
                              //tuSE.Add(obj cần đưa vào);
                              //Có 2 cách, new bên ngoài rồi đưa vào
                              //new ngay trên tham số hàm, vì cuối cùng đều là trỏ vào vùng new.
            Student s1 = new Student() { Id = "SE1", Name = "An Nguyen", };
            Student s2 = new Student() { Id = "SE2", Name = "Binh Nguyen", Yob = 2004, Gpa = 2.5 };
            Student s3 = new Student() { Id = "SE3", Name = "Cuong Nguyen", };
            Student s4 = new Student() { Id = "SE4", Name = "Dung Nguyen", };

            tuSE.Add(s1);
            tuSE.Add(s2);
            tuSE.Add(s3);
            tuSE.Add(s4);

            tuSE.Add(new Student() { Id = "SE5", Name = "Em X", Yob = 2000, Gpa = 10 });
            tuSE.Add(new Student() { }); //1 bộ hồ sơ bỏ trống info
            tuSE.PrintList();
        }
    }
}
