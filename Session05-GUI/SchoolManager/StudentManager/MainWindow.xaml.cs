using StudentManager.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// ĐẰNG SAU MỖI MÀN HÌNH LÀ 1 CLASS GỒM DÀI , RỘNG , MÀU SẮC NỀN , VÀ CÁC PROPERTY/ATTRIBUTE CHÍNH LÀ CÁC
    /// NUT NHẤN , ÔN NHẬP , DROPDOWN , DATAGRID , RADIO BUTTON
    /// CLASS NÀY NÓ CÒN PHẢI RENDER ĐƯỢC RA CHO USER THẤY 
    /// CLASSS NÀY TA TỰ DESIGN TỪ ĐẦU , PHẦN RENDER THÌ GỌI CARD ĐỒ HỌA - GRAPHICS CARD ( VGA)
    /// NHỮNG VIỆC NÀY CỰC KÌ KHÓ KHĂN , CHO NÊN MICRSOFT VÀ .NET SDK ĐÃ CUNG CẤP SẴN CHO TA 1 CLASS CHA LÀ
    /// WINDOW CHỊU TRÁCH NHIỆM TẠO RA CÁI CỬA SỔ CƠ BẢN , SAU ĐÓ TA LÀ DÂN DEV CHỦ ĐỘNG KẾ THỪA VÀ CHẾ BIẾN 
    /// DO ĐÓ , MỖI CỬA SỔ CỦA TA LÀM LÀ CỬA SỔ CON CỦA CỬA SỔ CHA WINDOW 
    /// TRONG C# , VIỆC KẾ THỪA DÙNG DẤU : (TƯƠNG ĐƯƠNG EXTENDS BÊN JAVA ) 
    /// VÀ  MUỖN CỬA SỔ RENDER RA TA GỌI HÀM .SHOW LÀ XONG , CỬA SỔ CHA SẼ LO
    /// : CHÍNH LÀ KẾ THỪA TRONG JAVA 
    /// 
    public partial class MainWindow : Window//CỬA SỔ CHA HÌNH CHỮ NHẬT
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadButtonClick(object sender, RoutedEventArgs e)
        {
            List<Student> arr = new List<Student>();
            arr.Add(new Student() { Id = "SE1" , Name = "An nguyen" , Yob = 2002 , Gpa = 9.2 });
            arr.Add(new Student() { Id = "SE2", Name = "Binh Le", Yob = 2001, Gpa = 9.1 });
            arr.Add(new Student() { Id = "SE3", Name = "Cuong VO", Yob = 2002, Gpa = 9.2 });
            StudentListDataGrid.ItemsSource = arr;

        }
    }
}