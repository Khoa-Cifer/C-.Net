namespace BasicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playWithPrimitiveArrayV5();
        }

        static void playWithPrimitiveArrayV5()
        {
            double[] rs = { 5, 10, 15, 20, 25, 30, 35.5, 40, 45, 50 };
            //Không cần chỉ ra số biến có trong mảng, kích thức mảng, số biến có trong mảng, sẽ ứng với số value đưa vào
            Console.WriteLine("The list of rain volumes");
            //Với mọi biến x rơi vào tập hợp rs - r đang chứa 10 con số double => x có thể = r[0], r[1],...
            foreach (int x in rs)
            {
                Console.Write($"{x} ");
            }
            //Các cách duyệt for
            //Dùng for each kiểu toán học
            //DÙng for i bình thường
            //Dùng for each kiểu biểu thức lambda

            //***Mảng object
            //Khai báo mảng có nhiều cách, em nên dùng cách nào
            //Thường ta sẽ dùng cách khai báo trước gán value sau
            //Lý do ta chưa thể biết hết các value của mảng để gán mà từ từ sẽ gán vào
            //Ngày mai chưa đến thì làm gì có mưa mà gán
            //Nên thường dùng
            //double[] rs = new double[3650] - Lưu lượng mưa của 10 năm
            //khai báo trước, từ từ gán
        }

        static void playWithPrimitiveArrayV4()
        {
            double[] rs = new double[]
            {
                5, 10, 15, 20, 25, 30, 35, 40, 45, 50
            }; //Không cần chỉ ra số biến có trong mảng, kích thức mảng, số biến có trong mảng, sẽ ứng với số value đưa vào

        }

            static void playWithPrimitiveArrayV3()
        {
            double[] rs = new double[10]
            {
                5, 10, 15, 20, 25, 30, 35, 40, 45, 50
            }; 
            //Khai báo và gán luôn value
            //Object initialization
            Console.WriteLine("List of ran volumes");
            for (int i = 0; i < rs.Length; i++)
            {
                Console.Write($"{rs[i]} ");
            }
            Console.WriteLine();
        }

        static void playWithPrimitiveArrayV2()
        {
            //Cần lưu trữ lượng mưa 10 ngày vừa rồi
            //Khai báo sỉ các biển
            double[] rs = new double[10];
            //Đã có 10 biến double được tạo ra, tương đương 10 biến abcdef như kiểu truyền thống
            //10 biến xài chung 1 tên, đó là r, để phân biệt 10 biến khác nhau cùng tên r, ta dùng thêm tên phụ gọi nhau = stt
            //r[0], r[1],... r[index] tính từ 0
            //Mảng là kĩ thuật khai báo nhiều biến cùng kiểu, cùng lúc, cùng tên, ở sát nhau trong ram
            //[index] là cách để gọi tên từng biến trong nhóm biến đã khai báo, còn gọi là phần tử của mảng, element
            //Tương tự trong lớp ở phổ thông có nhiều bạn trùng tên nhau, cô giáo đặt tên phụ để gọi từng bạn
            //Console.WriteLine("Day 1: " + rs[0]);
            //Console.WriteLine("Day 2: " + rs[1]);
            //Console.WriteLine("Day 3: " + rs[2]);
            //Vì con số thứ tụ tăng dần từ 0, ta dùng for
      
            //Có 10 biến, r[0], r[1], r[2],....
            rs[0] = 5;
            rs[1] = 10;
            rs[2] = 15;
            rs[3] = 20;
            rs[4] = 30;
            rs[5] = 40;
            rs[6] = 50;
            rs[7] = 70;
            rs[8] = 80;
            rs[9] = 90;
            Console.WriteLine("The list of rain volumes");
            for (int i = 0; i < rs.Length; i++)
            {
                Console.Write(rs[i] + " ");
            }
            Console.WriteLine();
            //r[969] = 69;
            //Chơi với mảng, nếu vượt bên, ngoài range của mảng, out of bound, sẽ nhận về exception, dừng app
        }

        //                  value type in c#
        static void playWithPrimitiveArrayV1()
        {
            //Cần lưu trữ lượng mưa 10 ngày vừa rồi
            double rain1, rain2, rain3, rain4, rain5, rain6, rain7, rain8, rain9, rain10;
            //Xin 10 vùng ram, 10 biến primitive lẻ và chưa gán value;

            //Console.WriteLine("Day 1" + rain1);
            //Biến chưa gán value mà xài là bị chửi

            //Khai báo biến và gán value
            double r1 = 5, r2 = 10, r3 = 15, r4 = 20, r5 = 25, r6 = 30, r7 = 35, r8 = 40, r9 = 45, r10 = 50;

            //In lượng mưa của 10 ngày
            Console.WriteLine("Day 1: " + r1);
            Console.WriteLine("Day 2: " + r2);
            Console.WriteLine("Day 3: " + r3);
            Console.WriteLine("Day 4: {0}", r4);
            Console.WriteLine("Day 5: " + r5);
            Console.WriteLine("Day 6: " + r6);
            Console.WriteLine($"Day 7: {r7}");
            Console.WriteLine("Day 8: " + r8);
            Console.WriteLine("Day 9: " + r9);
            Console.WriteLine("Day 10: " + r10);
            //Khai báo lẻ từng biến, dễ làm, dễ hiểu nhưng tốn thời gian nếu có quá nhiều biến để xử lí
            //Mảng sẽ giúp ta tiết kiệm công sức gõ, code ngắn mà vẫn đạt mục tiêu, coolections, list, array list cũng nhằm mục đích đó
        }
    }
}

//Ôn lại về data type - kiểu dữ liệu - hình dáng của dữ liệu
//Kí tự, số, số lẻ thập phân, điều đúng sai, (Hình dáng của data)

//Có 2 loại kiểu dữ liệu, dữ liệu đến qua 2 hình dạng
//1. Kiểu dữ liệu nguyên thuỷ, đơn giản, đơn giá trị, kdl single value
//* Java gọi kiểu đơn giản là primitive
//* C#   gọi là               value type (dạng giá trị đơn)
//* int, long, float, double, char, bool/boolean

//2. Kiểu dữ liệu phức tạp, phức hợp, complex, composite, kdl object
//* Phức tạp nghĩa là nó gồm bên trong nhiều miếng thông tin nhỏ hơn
//* File, String/string, Double, Random, StringTokenizer, StringBuffer, SqlCommand, SqlStatement, Student, Lecturer, Person, Cat, Order
//Student {id, name, yob, gpa}
//BankAccount {id (string, balance (double), Owner(Person) }

//1. Có biến là có vùng ram được cấp
//2. Có new là có vùng ram được cấp, vùng ram chứa các info của object được đổ vào.
//3. Biến primitive xài đúng 1 vùng ram được cấp.
//   int yob = 2004; //lấy tên biến là có value, 1 vùng ram
//4. Biến object cần thêm 1 vùng ram new để trỏ đến. Object cần 2 vùng ram, 1 vùng cho biến con trỏ, 1 vùng new lớn.
//5. Sờ vùng new qua toán tử dấu chấm, vào vùng new gọi hàm public nào đó qua toán từ dấu chấm.

//Ta đã xong việc thiết kế cơ bản 1 class, từ class ra được các object (Mỗi lần new, 1 lần object được tạo)
//Ta chuyển giai đoạn, quản lí nhiều object
//Nhiều object, bắt chúng làm việc gì đó, ví dụ in danh sách bảng điểm của 35 sv, ko lẽ 35 câu lệnh flex(), viết ít mà ra được nhiều việc.
//Ta sẽ dùng mảng -array, list (array list), dictionary (MAP)
//Khác chút tên gọi với Java, nhưng cách hành xử giống Java.