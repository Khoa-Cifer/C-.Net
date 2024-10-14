namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //biến và giá trị khởi đầu là 5
            //lấy giá trị khởi đầu của n
            //tên biến là get
            Console.WriteLine("Get N: " + n);
            Console.WriteLine("Get N: {0}", n);
            Console.WriteLine($"Get N: {n}");


            //Set, thay đổi value của n
            n = 10; //Biến = value, nghĩa là thiết lập sự thay đổi giá trị cho biến, set biết
            Console.WriteLine($"Get N again: {n}");
            //Tên biến đã bao gồm get() set()
        }
    }
}
