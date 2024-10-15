using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Services
{
    //Class cabinet như cái thùng chứa, như cái hộp, dùng để chứa nhiều object/info bên trong, được thiết kế để lưu trữ info của các object student, ban đầu được khai báo bên trong có field là Student[] _arr
    //1 class mà thiết kế và chỉ làm việc sẵn với 1 vài class khác, ví dụ Cabinet ban đầu chỉ làm việc và chứa Student, thì hiện tượng 2 class gắn với nhau gọi là Tight Coupling, khi đó nó khiến cho class làm việc với chỉ 1 class khác, làm class thiếu tính linh hoạt khi muốn chơi với nhiều class
    //Khi ta biết rằng nếu 1 class có thể làm việc được với nhiều class khác, khi đó ta có thể tân dụng viết code không cần quá nhiều lần mà vẫn xử lí được nhiều thông tin khác nhau, do đó, ta đi đến kĩ thuật thiết kế mới, class có thể làm việc với nhiều dạng class khác nhau
    //Hiện tượng 2 class kết nối lỏng lẻo -> Loose Coupling.
    //Và generic<?> là 1 dạng như thế, nó giúp class có thể làm việc với nhiều class khác, thay thế ở phần <?>

    //Vậy generic là cách mà 1 class có thể nhận vào 1 class khác để làm việc với đa dạng thông tin khác nhau.
    //Vậy lần đầu tiên 1 class, 1 data type có thể truyền vào như là tham số, data type là tham số luôn
    public class Cabinet<T> //T ở đầu có thể là Student, Lecturer
    {
        private T[] _arr; //có thể = Student[], Lecturer[]
        private int _count = 0; //_count có thể không cần gán giá trị vì sẽ mang default khi new, nhưng ta ghi ra để rõ ràng

        //Constructor ta sẽ phi chuẩn hoá, tức là không hoàn toàn truyền thống, ta vẫn nhận đầu vào để đi làm 1 việc khác, đầu vào này dùng để new 1 mảng với 1 kích thước theo nhu cầu !
        //Tức là vẫn có đầu vào, vẫn cần đầu vào, nhưng đầu vào dùng để thay đổi info bên trong object, vẫn cùng 1 mục dích, đầu vào của constructor dùng để tạo ra object theo nhu cầu
        //Nếu đầu vào cà chớn, ta sẽ set default hoặc ném ra ngoại lệ.
        //Nếu đầu vào cà chớn và ta ném ra ngoại lệ, thì khi đó constructor chạy không thành công, nguyên lí của exception là khi có điều bất thường, app sẽ bị dừng, hàm sẽ bị dừng.
        //Do đó, khi constructor ném ra ngoại lệ là hàm new chay không được, không có object được tạo ra.

        public Cabinet(int size)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException("Ivnvalid size, size must be >= 1");
            }

            _arr = new T[size]; //New mảng size với phần tử hợp lệ nếu chay thành công và không có exception.
        }

        public void Add(T obj)
        {
            //Kiểm tra mảng full hay không
            if (_count == _arr.Length)
            {
                Console.WriteLine("The list is full, no more space to add");
                return;
            }

            //Mảng chưa full, add bình thường vào vị trí thứ count
            _arr[_count++] = obj;
            //bên ngoài truyền vào vùng new Studnet(){} new Lecturer(){}
            //Vùng new này qua biến object, đi vào biến _arr[i]
            //Truyền object, pass by reference là pass toạ độ vùng new
            //Object nhận vào vùng new, _arr[i] nhận cùng toạ độ vùng new này
        }

        //In mảng, cấm xài for hết, vì mảng chưa chắc đã full
        public void PrintList()
        {
            if (_count == 0)
            {
                Console.WriteLine("There is no item, nothing to print");
                return;
            }

            //Mảng có data, for đến count;
            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
