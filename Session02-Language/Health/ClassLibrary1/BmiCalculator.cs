namespace Bmi
{
    //document huong dan su dung truoc khi dung ham o trong thu vien
    //ham truyen thong, goi tu thu vien .dll, .jar
    //ham hien dai, goi tu URL, http...
    //ham nay goi la web api
    //va docuent huong dan xai ham goi tu web goi la
    //web api document -> swagger UI

    /// <summary>
    /// This class offers methods for evaluating the health status based on weight and height of someone.
    /// Class nay cung cap cac ham de tinh toan chi so suc khoe dua tren chieu cao va can nang.
    /// </summary>

    public class BmiCalculator
    {
        /// <summary>
        /// This method return the bmi indicator based on weight and height
        /// </summary>
        /// <param name="weight">Weight is based on kg</param>
        /// <param name="height">Height is based on m</param>
        /// <returns></returns>
        public static double GetBmi(double weight, double height) => weight / Math.Pow(height, 2);
        
    }
}
