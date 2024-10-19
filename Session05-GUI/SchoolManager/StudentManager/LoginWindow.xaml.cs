using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentManager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //nút bấm này ta sẽ chuyển trang , sang màn hình chính 
            //nên nhớ mỗi màn hjình ứng vs 1 class
            //để có 1 màn hình hiển thị , tức là màn hình phải vào ram -> tức là ta phải new object , new màn hình 
            //mà muốn new màn hình ta phải khai báo biến và new -> công thức OOP chuẩn
            MainWindow mainWindow = new MainWindow();
            //vào ram , chứ chưa render 
            //mainWindow.Show();//gọi card đồ họa ( NVIDIA , AMD ... )
            //ta hạn chế lại ko cho nhấn nút thì new mới vô tội vạ do 
            //nếu là màn hình tạo mới thì cùng lúc có nhiều màn hình tạo mới , ta sẽ khó quản lí id của sản phẩm mới tạo
            //nên ta khống chế lại nút bấm này , tại 1 thời điểm chỉ có 1 màn hình đc popup lên , đc mở thêm
            // làm xong màn hình mới mở , tắt đi quay trở lại màn hình trước mới đc bấm tiếp
            // cơ chế ko cho mở quá nhiều màn hình gọi là show màn hình theo hình thức hộp thoại (dialog)
            //kẻ nói phải có người nghe , xong 1 đoạn hội thoại r tính tiếp

            mainWindow.ShowDialog();
       

         
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //trong trang web có hàm alert() để popup ,và show thông tin gì đó
            // bên này cx có 1 hàm tương tự đẻ show info dạng popup
            //MessageBox.Show("Hello WPF . WPF is so funny","Hello announcements");
            //Trong WPF nói chung , mọi thứ đều là object , đều thuộc về 1 class nào đó dù là điều nhỏ nhặt nhất '
            // nguyên lí chữ S trong SOLID luôn hiện hữu ( SINGLE RESPONSIBILITY)
            //tính đơn trách nhiệm khi thiết kế class , mỗi class chuyên về việc gì thì nên làm việc đó
            //Vậy thì có class chuyên dành để hiển thị thông báo : 
            // Class MessageBox , 
            // có class chuyên quản lí các nút bấm trong thông báo MessageBox : class MessageBoxButton 
            //có class chuyên quản lí hình ảnh chèn vào MessageBox -> class MessageBoxImage xuất hiện 
            //có class chuyên dùng để hứng các nút bấm trả về của màn hình MessageBox -> class MessageBoxResult xuất hiện
            //Vậy để hiển thị một pop up với hình ảnh , nút bấm đa dạng cà bắt đc nút gì đã chọn , ta cần các class sau :
            //MessageBox , MessageBoxButton , MessageBoxResult ,MessageBoxImage
            //
           
            MessageBoxResult answer = MessageBox.Show("Do you really want to quit", "Quit ?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes) 
            {
                Application.Current.Shutdown();
            }

        }
    }
}
