namespace PassByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithOut(3000);Khong duoc, phai dua 1 bien vao co
            //var n = 3979;
            //Console.WriteLine("Before calling out method, n is:" + n);
            //PlayWithOut(out n); //n la bien de hung value tra ve nhu dung return
            //Console.WriteLine("After calling out method, n is:" + n);

            //int x;
            //PlayWithOut(out x); //Khong can gan value san cho bien out, vi se co trong ham tra ra
            //Console.WriteLine("After calling out method, x is:" + x);

            ////Co the dung
            //PlayWithOut(out int xxx); //khai bao style inline, khai bao bien tu ham out o ngay cau lenh goi ham.
            //Console.WriteLine("xxx: " + xxx);
            var sumAll = SumIntegerList(out int odds, out int evens);
            Console.WriteLine(sumAll);
            Console.WriteLine(odds);
            Console.WriteLine(evens);
        }
        //Khi nao dung out
        //Challenge: Viet ham tinh tong cac so tu 1->10
        //Challenge: Viet ham tinh tong cac so chan tu 1->10
        //Challenge: Viet ham tinh tong cac so le tu 1->10
        //Viet chung 1 ham, tra ve ca 3 gia tri, ko in
        static int SumIntegerList(out int sumOdds, out int sumEvens)
        {
            var sumAll = 0;
            sumOdds = 0;
            sumEvens = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll = sumAll + i;
                if (i % 2 == 0)
                {
                    sumEvens = sumEvens + i;
                } 
                else
                {
                    sumOdds = sumOdds + i;
                }
            }
            return sumAll;
        }

        static void PlayWithOut(out int n)
        {
            //Ham co tu khoa out, nghia la, em hua se co 1 gia tri duoc gan cho n, phai co cau lenh n = gia tri gi do, tuong duong lenh return;
            //Console.WriteLine(n); //Chua co gia tri n, khong in duoc
            //out thay doi ve parameter theo huong tra ra thay vi nhan vao
            n = 6789;
            //Console.WriteLine(n);
        }

        //Truyen tham chieu la dac quyen cua bien Object
        //Truyen tham chieu con co the ap dung ch bien primivite/value-type: int long float double char bool short byte.
        //Ta co the dung 2 keyword out va ref de bien 2 bien primitive thanh bien  ta
    }
}
