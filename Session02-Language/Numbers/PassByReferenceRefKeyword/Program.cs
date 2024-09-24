namespace PassByReferenceRefKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithOut(5000);
            //Out và ref không chấp nhận 1 con số cụ thể - Literal value, mà phải là 1 biến để hứng value để hứng value
            PlayWithOut(out int n1);
            Console.WriteLine("n: " + n1);

            //PlayWithRef(ref int n2); //Không cho xài inline như out
            //Gọi hàm là mong muốn xử lí gì đó, gọi hàm trả về mong có được trả về, ref thì không hứa nên không chắc sau khi gọi ref có value hay không. -> Không xài inline, do inline không gán default được

            int n2 = 69;
            PlayWithRef(ref n2); //N2 bằng mấy, tuỳ, vì lần này n2 có value default, nếu không có giá trị trả về thì lấy value của n2
            Console.WriteLine("n2: " + n2);
        }

        //Out và Ref giống nhau, trong hàm mà sửa, bên ngoài sửa theo - pass by reference, ta đứng trong hàm nhưng ta tác động ngoài kia.
        //Viết hàm nhận vào trả ra 1 con số bất kì (Hàm random)
        static void PlayWithOut(out int n)
        {
            //n sẽ phải có value nào đó được ném ra
            n = 0;
        }

        static void PlayWithRef(ref int n)
        {
            n = 6969;
            //n không bắt buộc phải có value trả về
        }

        //Xài out sẽ dễ kiểm soát đầu ra một cách chắc chắn
    }
}
