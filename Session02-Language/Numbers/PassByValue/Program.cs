namespace PassByValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerByTwo(5);
            var x = 10;
            PowerByTwo(x);
            Console.WriteLine("After calling method, x finally is: " + x);
        }

        //Pass by value: Ham nhan vao gia tri tu ben ngoai, 1 dai luong tu ben ngoai truyen vao
        //Ben trong ham chinh sua, ben ngoai giu nguyen
        //Truyen tham tri ap dung cho bien primitive (Java) Value-Type(C#): int, long, float, double, char, boolean, bool, short, byte
        //Nhung bien ma gia tri don gian, don le, 1 gia tri don

        //Khong ap dung duoc cho kieu object(Object la kieu tham chieu)
                                            //Student, Lecturer, Employee, Dog, Cat

        //Ham nay binh phuong con so dau vao
        static void PowerByTwo(int n)
        {
            Console.WriteLine("In method, before updating, n is: " + n);
            n = n * n; //n = Math.Pow(n, 2); dau vao n bi thay doi gia tri
            Console.WriteLine("In method, after updating, n is: " + n);
        }
    }
}
