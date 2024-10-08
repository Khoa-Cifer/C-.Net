using ObjectArray.Entities;

namespace ObjectArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playWithStudentListV3();
        }

        static void playWithStudentListV4()
        {
            //int[] arr = { 5, 10, 15, 20, 25, 30 };
            //           [0] [1] [2] [3] [4] [5]
            //Student[] arr = { new Student(), new Student(), new Student(), new Student() }
            Student[] arr = {
                new Student() { Id = 1, Name = "An", Yob = 2004, Gpa = 8.9 },
                new Student() { Id = 2, Name = "Binh", Yob = 2004, Gpa = 8.9 },
                new Student() { Id = 3, Name = "Cuong", Yob = 2004, Gpa = 8.9 },
                new Student() { Id = 5, Name = "En", Yob = 2004, Gpa = 8.9 }
            };

            //Được quyền foreach/for length
        }

        static void playWithStudentListV3()
        {
            Student[] arr = new Student[500];
            arr[0] = new Student() { Id = 1, Name = "An", Yob = 2004, Gpa = 8.9 };
            arr[1] = new Student() { Id = 2, Name = "Binh", Yob = 2004, Gpa = 8.9 };
            arr[2] = new Student() { Id = 3, Name = "Cuong", Yob = 2004, Gpa = 8.9 };
            arr[3] = new Student() { Id = 4, Name = "Dung", Yob = 2004, Gpa = 8.9 };
            arr[4] = new Student() { Id = 5, Name = "En", Yob = 2004, Gpa = 8.9 };
            arr[5] = arr[4];
            //2 chàng trỏ 1 nàng, 1 sv ngoài đười được ghi danh sách, đếm 2 lần
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

            arr[5].Name = "Chung minh co van de khong em";

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
            //5 sửa, 4 cũng thế, vì cả 2 đều trỏ cùng 1 vùng ram
            //Mặc định các biến object = nhau, tức là cùng trỏ, tức là pass by reference, thằng này sửa thằng kia bị ảnh hưởng.
        }

        static void playWithStudentListV2()
        {
            //Challenge: lưu trữ thông tin của 500 student
            //Khai báo lẻ
            Student[] arr = new Student[500]; //500 students chưa biết là ai, 500 chỗ ngồi nhưng chưa ai ngồi
                                              //Mỗi student có tên là arr[0], arr[1], arr[2]
                                              //s1      s2      s3
                                              //Khai báo nhanh, tên biến phức tạp;
                                              //arr.Length => Biến má mì
                                              //Console.WriteLine(arr[0].Name); //arr[i] là 1 biến student;
                                              //Mặc định biến object student trong mảng 500 đều mang default là null, cho nên khi gọi hàm của phần tử [i]. là vỡ mặt
                                              //-> Null Reference Exception
                                              //Gán value
            arr[0] = new Student() { Id = 1, Name = "An", Yob = 2004, Gpa = 8.9 };
            arr[1] = new Student() { Id = 2, Name = "Binh", Yob = 2004, Gpa = 8.9 };
            arr[2] = new Student() { Id = 3, Name = "Cuong", Yob = 2004, Gpa = 8.9 };
            arr[3] = new Student() { Id = 4, Name = "Dung", Yob = 2004, Gpa = 8.9 };
            arr[4] = new Student() { Id = 5, Name = "En", Yob = 2004, Gpa = 8.9 };

            Console.WriteLine("The list of 500 students");
            //for (int i = 0; i < arr.Length; i++)
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arr[i].ToString());
            //}
            //Khi chơi với mảng object, cấm for hết mảng, vì phần cuối của mảng mặc định trỏ null -- null reference exception
            //-> Không dùng for đến length, foreach nếu biét mảng chưa full
            //Vậy khi chơi với mảng (Object, primitive), nên cần 1 biến count để đếm số phần tử trong mảng đã được gán value, và ta chỉ for đến count
            //count = 0, thêm 1 phần tử thì count++;
            //Đếm, for đến số người có mặt
            //0976849500
            foreach (var x in arr)
            {//X là biến lẻ student x, có quyền bằng 1 trong những arr[i]
                //x = arr[0], x = arr[1], x = arr[2]
                Console.WriteLine(x.ToString());
            }
        }

        //ctrl , K, D, align code
        static void playWithStudentListV1()
        {
            //Chanlenge: hãy lưu trữ thông tin của 5 bạn sinh viên
            Student s1, s2, s3, s4, s5; //Khai báo lẻ từng biến, chưa gán value
            //Console.WriteLine(s1.Name); //Biến chưa gán value
            //s1 = null; //Trỏ đáy ram
            //Console.WriteLine(s1.Name);
            //Exception, đáy ram không có hàm GetName(), .Name là GetName() -> Null reference exception
            //Gán value tử tế, trỏ vùng new student
            s1 = new Student() { Id = 1, Name = "An", Yob = 2004, Gpa = 8.9 };
            s2 = new Student() { Id = 2, Name = "Binh", Yob = 2004, Gpa = 8.9 };
            s3 = new Student() { Id = 3, Name = "Cuong", Yob = 2004, Gpa = 8.9 };
            s4 = new Student() { Id = 4, Name = "Dung", Yob = 2004, Gpa = 8.9 };
            s5 = new Student() { Id = 5, Name = "En", Yob = 2004, Gpa = 8.9 };

            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Name);
            Console.WriteLine($"{s5.Name}");
        }
    }
}

//Kết luận và mở rộng bài toán
//1. Ta đã xong thiết kế 1 class, gồm _field và hàm get set,
                            //hoặc gồm _backingField và Property,
                            //hoặc bỏ luôn _backingField, chỉ còn Property
//  Ta có class student và các class tương tự, lecturer, employee, dog, cat
//2. Ta đã học được cách lưu trữ nhiều object hiệu quả qua việc dùng mảng
//Mảng: Khai báo nhiều biến (Biến primitive hay object), từ từ ta gán giá trị cho phần tử thứ i của mảng
//Add mới món đồ vào mảng
//Ta có lôi ra 1 object ở vị trí thứ i, để in, để chỉnh sửa, update 1 món trong mảng
//Ta sẽ có crud method, thêm xoá sửa, in ấn
//phần tử trong mảng
//Câu lệnh khai báo mảng, gán giá trị cho mảng, in mảng, tìm phần tử trong mảng, những câu lệnh này ta để ở đâu
//Ở main không phù hợp, main sẽ là nơi gọi các object được tạo từ các class

//Có class sinh viên
//Chỗ nào để lưu mảng sinh viên, thêm xoá sửa sinh viên

//Nguyên lý chữ S trong SOLID: Single Responsibity - Tính đơn trách nhiệm trong thiết kế class
//1 class chỉ nên làm 1 việc

//Ở ngoài đời, nơi nào lưu thông tin sinh viên
//Phòng dịch vụ sinh viên, phòng đào tạo
//Phía sau lưng phòng này là các tủ hồ sơ có không gian đủ rộng để chứa các hồ sơ, các mảng hồ sơ
//Phòng đào tạo cung cấp các dịch vụ thao tác data
//Class cái tủ nằm ở package services xuất hiện