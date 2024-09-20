namespace PassByInKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = -3000;
            PrintIntegerList(n);
            Console.WriteLine("In main(), n after calling method, n finally is " + n);

            //Chua chay ham, chay code, ma minh doan rang bien phai la gia tri may
            //Ham phai in ra cai gi, thi cac gia tri nay goi la expected value
            //Thuc te, cho chay xem da, actual value. ca 2 == nhau -> ham MLEM
                                                         //!=      -> bug
        }

        //Tu khoa in se bien tham so thanh read only, chi xai, khong duoc gan lai value
        //TODO AT HOME: in ma di kem bien object thi readonly con mang y nghia nhu o vi du nay hay khong.
        //void Fx(Student s)
        //void Fx(in Student s)
        static void PrintIntegerListV2(in int n)
        {
            //Validation
            if (n < 1)
            {
                Console.WriteLine("Invalid n. n must be >= 1");
                Console.WriteLine("For now, n is temporarily set to a default value of 2204");
                //n = 2204;
                return;
            }
            //ko xai else ma van la else
            Console.WriteLine("The list of numbers from 1 to " + n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine(); //In xong xuong hang
        }

        //Challenge: Viet ham nhan vao so n >= 1 va in ra so tu nhien tu 1 den n
        static void PrintIntegerList(int n)
        {
            //Validation
            if (n < 1)
            {
                Console.WriteLine("Invalid n. n must be >= 1");
                Console.WriteLine("For now, n is temporarily set to a default value of 2204");
                n = 2204;
            }
            //ko xai else ma van la else
            Console.WriteLine("The list of numbers from 1 to " + n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine(); //In xong xuong hang
        }
    }
}
