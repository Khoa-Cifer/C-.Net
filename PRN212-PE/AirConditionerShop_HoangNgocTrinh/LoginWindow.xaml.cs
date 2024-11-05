using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Models;
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

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserService _userService = new();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //1. Check đã nhập đủ thông tin chưa
            //Check xem gõ đủ email/password hay không
            string email = EmailAddressTextBox.Text.Trim(); //cắt dấu space trước và sau email
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and password are required !", "Field required exception", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //sai thì return trả luôn
            }

            //2. Check login thành công hay không
            StaffMember result = _userService.Authenticate(email, password);

            if (result == null)
            {
                MessageBox.Show("Invalid email and password !", "Invalid email or password", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //sai thì return trả luôn
            }

            //3. Check role: Manager 3 -> không vào, admin -> vào, staff -> vào nhưng không có quyền hạn
            if (result.Role == 3)
            {
                MessageBox.Show("You have no permission");
                return;
            }
            MessageBox.Show("You login with role " + result.Role);
            MainWindow window = new MainWindow();
            window.AuthenticatedUser = result; //chuyển result sang main, trỏ cùng 1 object
            window.Show();
            this.Close();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
