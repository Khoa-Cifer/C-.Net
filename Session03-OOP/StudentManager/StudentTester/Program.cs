using StudentTester.Entities;
//~import java.util.*

namespace StudentTester
{
    //Trong 1 namespace có nhiều class
    //Class thuộc namespace chính là ứng với 1 thư mục chứa nó
    //Trong namespace bạn có quyền khai báo những thứ sau
    //class và những thứ bằng class: Interface, Delegates

    //Ta không nên gộp các class vào 1 tận tin vật lí như code ớ dưỡi mà nên tách từng class thành 1 tập tin riêng lẻ, quản lí source code dễ dàng hơn
    //public class Lyric
    //{

    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Chúng ta luôn đặt tên cho mọi thứ quanh ta, dù là phức tạp hay đơn giản.
            //Biến là tên gọi cho 1 Value
            //3.14 -> pi
            double pi = 3.1415;
            //10% gọi là VAT, discount
            double vat = 0.1;
            //NTT, 1994, TB, NV TPHCM, HT, CTCTL -> Sếp
            //Singer sep = new Singer(NTT, 1994, TB, NV TPHCM, HT, CTCTL);
            Student an = new Student("SE1", "An Nguyen", 2004, 8.6);
            Student binh = new("SE2", "Binh Le", 2004, 7.5);
            //Style new mới, rút bớt new cái gì, vì vế trái còn manh mối Student, rút gọn bên phải
            var cuong = new Student("SE3", "Cuong Vo", 2005, 8.4);
            //Type Inference, Suy luận kiểu
            //var dung = new("SE4", "Dung Pham", 2006, 0.1);
            //Không được, không có manh mối để cấp vùng ram.

            var dung = new Student("SE4", "Dung Pham", 2006, 0.1);

            //var em = new Student(2000, 3.99, "SE5", "Em Nam");
            //Không đảo lộn thứ tự datatype của biến đầu vào
            var em = new Student(yob: 2004, gpa: 3.9, id: "SE5", name: "Em Nam");
            //Cho phép truyền data vào hàm mà không cần tuân theo thứ tự biến đầu vào, không cần nhớ chặt chẽ thứ tự biến đầu vào.
            //Kĩ thuật này gọi là Named-Argument, tham số đưa vào hàm kèm tên tham số
            an.FlexProfile();
            binh.FlexProfile();
            cuong.FlexProfile();
            dung.FlexProfile();
            em.FlexProfile();

            Console.WriteLine("Your Name ?");
            Console.WriteLine(an.GetName());
            Console.WriteLine(binh.GetName());
            Console.WriteLine(cuong.GetName());
            Console.WriteLine(dung.GetName());
            Console.WriteLine(em.GetName());
            //Tối ưu các lệnh gọi flex, không cần gọi nhiều lệnh như thế này

            //Thay đổi info của object
            //Cập nhật điểm của bạn An thành 9.0
            Console.WriteLine("An Before updating grade: ");
            an.FlexProfile();
            an.SetGpa(9.9);
            //Set không tạo ra object nhưng constructor, mà set sửa object đã tạo
            Console.WriteLine("An After updating grade: ");
            an.FlexProfile();

            Student s = an;
            //2 biến s và an cùng trỏ chung 1 vùng new(...)
            //Đứa này sửa vùng new, đứa kia thấy luôn
            s.SetGpa(0.1);
            //An điểm mấy
            Console.WriteLine("An info");
            an.FlexProfile();

            //2 biến object gán bằng nhau, là gán cùng toạ độ, trỏ cùng 1 địa chỉ, là truyền tham chiếu
            //Măc định hàm nhận vào biến object chính là nhận vào con trỏ.
            //Mặc định, gán giá trị cho biến object, là truyền tham chiếu - Pass By Reference
            an = null;
            //an != null
            if (an is not null)
            {
                an.FlexProfile();
            }
            else
            {
                Console.WriteLine("An points to the null, Nothing to print");
            }
            Student xxx = s; //Cột vùng new lại trước khi s về null
            s = null;
            //Nếu 1 vùng new object không có biến nào trỏ đến, thì vùng new đó sẽ bị garbage collector - chương trình thu gom vùng nhớ rác của runtime sẽ clear, dọn dẹp, coi như vùng object không còn tồn tại để giúp tái sử dụng vùng ram cho các object khác.
            //System.GC.Collect();
            xxx.FlexProfile();
        }
    }
}
