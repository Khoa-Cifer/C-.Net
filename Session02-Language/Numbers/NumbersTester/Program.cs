namespace NumbersTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintIntegerList();
            SumOddsEvens();
        }

        //CHALLENGE 1: VIET HAM IN RA CAC SO TU 1 DEN 100 VA TINH TONG
        static void PlayWithVariables()
        {
            //Khai bao bien
            //Bien la 1 vung ram duoc dat ten chiem 1 so byte de luu data
            int a = 5; int b = 10; //declare and assign variable
            int c = 20, d =30;
            int e;
            e = 15;

            var f = 20; //lam bieng khai bao kieu du lieu
            //f se co data type dua tren value dc gan cho no
            //f se la int trong tinh huong nay do f la 20
            //f = 3.14, sai vi f la int

            var g = 30; //neu ko co value thi se bao loi do cpu khong biet kich thuoc bien de bo tri vung ram cho phu hop, do do dung var phai gan ngay value. -> Goi la su suy luan kieu, type inferrence.
        }

        static void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers from 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i} ");
                //Console.WriteLine("{0} ", i);
                //Console.WriteLine(i + " ");
            }

            //for if else duoc quyen bo ngoac nhon neu chi co 1 lenh trong do
            //Tinh tong
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum: {0}", sum);
            //Hy vong tra ve 5050 -> Expected value
            //Ket qua tra ve thuc te -> Actual value
            //Expected == Actual -> Passed
            //         !=        -> Bug

            //for (; ; ) Khong phai loi, for nay van chay, lap vo tan
            //{
            //}
        }

        //Challenge 2: Viet ham tinh tong cac so chan tu 1->10
                     //Viet ham tinh tong cac so le tu 1->10
                     //1 3 5 7 9 -> Expected: 25
                     //2 4 6 8 10 -> Expected 30
        static void SumOddsEvens()
        {
            int sumOdds = 0;
            int sumEvens = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvens = sumEvens + i;
                } 
                else
                {
                    sumOdds = sumOdds + i;
                }
            }

            Console.WriteLine($"Odds: {sumOdds}");
            Console.WriteLine($"Even: {sumEvens}");
        }
    }
}
