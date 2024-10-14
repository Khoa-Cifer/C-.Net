using StudentTesterV4.Entities;

namespace StudentTesterV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo mới object, class không có constructor, thì ta dùng constructor default
            Student an = new(); //Student an = new Student();
                                        //var an = new Student();
                                        //Named argument: new Student(name: "An Nguyen", yob: 8.4);
                                        //An mang default rất nhiều bên trong vùng new
                                        //Chữ rỗng, số là 0, bool là false
            Console.WriteLine("An at fisrt: " + an); //gọi tầm tên em, ToString();

            //an.SetName("An Nguyen");
            an.Id = "SE1";
            an.Name = "An Nguyen";
            an.Gpa = 8.6;
            an.Yob = 2004; //hết sức tự nhiên
            Console.WriteLine("An after setting: " + an);

            Student binh = new Student() { Id = "SE2", Name = "Binh Le", Gpa = 8.6, Yob = 2004};
            //New và set() trên cùng 1 câu lệnh cho gọn và đẹp
            //Cho phép ta đưa data vào object theo thứ tự bất kì
            //New theo style này giúp ta linh hoạt đổ data, không cần tạo nhiều constructor nữa
            //Cú pháp new qua style gọi hàm set gọi là:
            //Object initialization
            Console.WriteLine("Binh after setting: " + binh);
        }
    }
}
