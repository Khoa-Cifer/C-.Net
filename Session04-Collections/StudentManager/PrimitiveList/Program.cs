using PrimitiveList.Entities;
using System.Collections;

namespace PrimitiveList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentList();
        }

        static void PlayWithStudentList()
        {
            List<Student> list = new List<Student>();
            //list trỏ vùng new chỉ để chứa các biến Student
            //Từ từ thêm nếu add thêm Student
            list.Add(new Student());
            list.Add(new Student() { Id = "SE1", Name = "An", Gpa = 8, Yob = 2004 });
            list.Add(new Student() { Id = "SE2", Name = "An", Gpa = 8, Yob = 2004 });
            list.Add(new Student() { Id = "SE3", Name = "An", Gpa = 8, Yob = 2004 });

            Student s = new Student() { Id = "SE1", Name = "An", Gpa = 8, Yob = 2004 };
            list.Add(s); //Hàm add cần 1 biến student, biến trỏ vùng new, bên trong arr có 1 biến student cùng trỏ với new mà s đang trỏ
            //foreach được

            Console.WriteLine("The list of students printed by fori");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                Console.WriteLine(list.ElementAt(i));
            }

            //In với foreach
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void PlayWithNonGenericList()
        {
            ArrayList tuSE = new ArrayList();
            tuSE.Add(1);
            tuSE.Add(100);
            tuSE.Add(10);
            tuSE.Add("XXX");
            tuSE.Add(69.69);
            tuSE.Add(true);
            //tuSE.Add(new Student()); ///ok luôn nếu có class này
            //Mảng này lộn xộn data type, foreach thì ok, do mảng tự giãn, vì nó không cấp dư, fix cứng data được yêu cầu
            //Không cần biến _count lẻ, vì có .Count ở trong rồi {GET; } như .Length.
            Console.WriteLine($"The size of tuSE: {tuSE.Count}");
            foreach (var item in tuSE)
            {
                Console.WriteLine(item);
            }

            //Không nên dùng, vì lưu lộn xộn datatype, nên dùng generic cùng style
            //Túi đựng đồng nhất các món đồ
            //Tủ chén, tủ quần áo riêng, nhưng được gọi chung là tủ.s
        }
    }
}

//Java và C# cung cấp nhiều class dùng để lưu trữ và xử lí nhiều object trong RAM. những class này được gọi chung là Collections.
//Về lý thuyết chung, collections trong java và c# giống nhau, chỉ khác biệt trong cách đặt tên, hầu hết các class này đều chơi với generic, tức là sẽ linh hoạt với nhiều loại object
//Các class này chia thành 2 dạng, abstract class, và interface. Dạng này cấm new, vì nó chứa hàm không code
//Interface cấm new vì nó không có code
//Dạng còn lại thì ta có quyền new biến được đưa vào, túi đầy lên từ từ các biến được add vào
//Dạng class mà được quyền new, gọi là concrete class - class cụ thể.

//Collections trong java - nhóm class sinh ra để thay thế mảng, lưu bên trong nhiều biến khác, mảng co giãn
//Cấm new - abstract class hoặc interface
//List      Set     Map
//Nếu cố new
//List<Student> arr = new List<>(); LẬp tức chuyển mode, bạn đang nhảy sang chế độ code anonymous class, bị nhận vào 20 hàm không có code, code từ interface/abstract
//Có con, như
//List                          Set                         Map
//ArrayList             HashSet || TreeSet              HashMap || TreeMap
//Vào thứ tự nào,       Ngẫu nhiên                      Chứa cặp K - V, data theo bộ 2 đứa key - value
//Đi ra thứ tự đó       Vào thứ tự x, có thể ra
//Vào [0] ra [0]        thứ tự y
//Tree là sohft, đưa vào là
//Sắp xếp
//Khai cha new cha, anonymous class;
//Khai cha new con, ok
//Khai con new con, ok

//List<Student> arr = new ArrayList<>();
//ArrayList<Student> arr = new ArrayList<>();
//List<Student> arr = new List<>(); không được

//C# thì giống và khác
//ArrayList bên C# thì không chơi với generic, tức là cái túi, khi ta new ArrayList thì chứa lộn xộn món đồ, add gì cũng được
//-> Không nên dùng
//C# khuyên dùng
//