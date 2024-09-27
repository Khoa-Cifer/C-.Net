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
            an.FlexProfile();
        }
    }
}
