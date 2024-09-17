using Bmi;
//~~ import ben java

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintBmiV2(85, 1.8);
            double bmi = BmiCalculator.GetBmi(85, 1.8);
            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine($"BMI: {bmi}");
            Console.WriteLine("BMI: {0}", BmiCalculator.GetBmi(85, 1.8));
            Console.WriteLine($"BMI: {BmiCalculator.GetBmi(85, 1.8)}");
        }

        //Challenge: Tinh va in ra chi so BMI
        //Do tinh trang map om dua tren chieu cao va can nang
        //BMI = can nang (kg) / chieu cao (m)^2

        //Triet ly thiet ke ham MLEM la 1 ham nhan vao va tra ra
        //Ham nhan vao va tra ra se tang tinh reuse, la ham de dang duoc su dung o nhieu noi do no chi la 1 gia tri cho nen no se duoc tich hop vao cac bieu thuc tinh toan khac

        //Ki thuat chi con cai day nit
        //{ CODE TRONG HAM } duoc goi la than ham - body of method
        //{ Implement of a method }
        //Neu 1 ham ma chi co duy nhat 1 lenh, ta duoc phep rut gon than ham, bo luon ngoac nhon, bo luon return, bo luon ngoac dong, noi ten ham va than ham da bi bo gan het qua dung ki tu =>
        //Expression body
        //Than ham nhin nhu bieu thuc
        //Khong nham voi lambda expression cung dung mui ten nay nhung y nghia khac
        static double getBmiV2(double weight, double height) => weight / Math.Pow(height, 2);
        
        static double getBmi(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }

        static void PrintBmiV2(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"bmi: {bmi}, w: {weight}, h: {height}");
        }

        static void PrintBmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine($"bmi: {bmi}, w: {weight}, h: {height}");
        }
    }
}
