namespace NullableTester
{
    //1 namespace chứa nhiều class. các class có thể nằm rải rác riêng rẽ trên từng tập tin ẻ khác nhau
    //Hoặc có thể nằm chung trong 1 tập tin vật lý như ở dưới đây như class Student và class Program chung namespace NullableTester.
    //Trong 1 namespace sẽ có nhiều class và ngang cơ với class - interface, abstract class, delegates
    //Nếu không có gì quá đặc biệt, thì ta nên tách mỗi class ra 1 file riêng lẻ để dễ dàng quản lí các tập tin, quản lí danh sách các class ở góc độ dễ nhìn, dễ thống kê, không nên gộp
    public interface Comparable
    {

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Mình thử viết class mà không dùng encapsulation
        //Không ẩn đi các properties

        public string id;   //ID: ...
        public string name; //Name: ...
        public int yob;     //Yob: ...
        public double gpa;  //Gpa: ...
        //Class giống như FORM, biểu mẫu, template, blueprint, bản thiết kế, bản phác thảo
        //Có khoảng trống để fill vật liệu vào, để có được 1 object, 1 bản copy.
        //Để có được biểu mẫu cho riêng mình - object (Căn cước công dân của mình), ta cần photo 1 bản Form - new, sau đó ta đổ info vào,.... phễu nhận parameter
        // Sau khi đổ vật liệu vào, điềm vào form đã được photo clone trên object.
        // Ta có 1 object và ta xem lại con ổn không -> getter get info
        // Ta lấy gôm tẩy xoá, set/seting chỉnh sửa sảng phẩm -> setter set info trên object.

        // Constructor - get/set
        //Nếu 1 class không làm constructor , không làm cái phễu để hứng vật liệu đưa vào thì ta vẫn luôn đúc được 1 object default, object không khí lấp đầy cái khuôn, ta có 1 tờ giấy photo trắng cần được viết
        //Nếu class cái không không có constructor, runtime tự tạo giúp ta 1 cái phễu default, phễu rỗng, phễu empty, không nhận đầu vào, không có code bên trong
        //public Student() { } -> Tự có

        //Sau khi có phễu, constructor dùng để nhận info, object được lấp đầy vật liệu/info ta có thẻ xem chúng, flex chúng, trưng bày chúng

        public void FlexProfile()
        {
            Console.WriteLine($"ID: {id} | NAME: {name} | GPA: {gpa} | YOB: {yob}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FlexProfile();
            student.id = "se1";
            student.name = "an nguyen";
            student.yob = 2004;
            student.gpa = 10;
            student.FlexProfile();

            //student = null;
            //student.FlexProfile();
        }
    }
}
