using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
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
        private UserService _service = new();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //Are you sure? rảnh mới làm
            Application.Current.Shutdown();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //1. LẤY INFO ĐÃ GÕ TỪ MÀN HÌNH LOGIN
            string email = EmailAddressTextBox.Text.Trim();
            string pass = PasswordTextBox.Text;

            //2. CHECK XEM CÓ BỎ TRỐNG 1 TRONG 2, HAY CẢ 2 HAY KO, CHỬI
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Both email and password are required!", "Fields required", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //early return, ko cần viết else
            }

            //3/ ĐÃ GÕ ĐỦ EMAIL, PASSS -> LOGIN HOY, BẰNG CÁCH GỌI SERVICE
            StaffMember? acc = _service.Authenticate(email, pass);

            //4. CHECK COI CÓ LOGIN THÀNH CÔNG VỚI EMAIL VÀ PASS ĐƯA VÀO HAY KO, KO THÀNH CÔNG, CHỬI SAI GÌ ĐÓ RỒI, SAI PASS HOẶC EMAIL (NGOÀI ĐỜI NÓI THẲNG: ACC KO TỒN TẠI, PASS BỊ SAI)
            if (acc == null)
            {
                MessageBox.Show("Invalid email or password!", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //early return, ko cần viết else
            }

            //5. ĐẾN ĐÂY LÀ ĐÚNG ACCOUNT RỒI, QUA CỬA AUTHEN; CHECK XEM CÓ ĐC ĐI TIẾP KO - PHÂN QUYỀN - PERMISSION 
            //CHECK ROLE, ĐANG NẰM TRONG 1 CỘT CỦA TABLE STAFF-MEMBER, PROP TÊN LÀ ROLE TRONG CLASS STAFF-MEMBER
            if (acc.Role == 3) //MANGER CẤM CỬA - PHÂN QUYỀN VÀO APP KHÁC
            {
                MessageBox.Show("You have no permission to access this function!", "Wrong permission", MessageBoxButton.OK, MessageBoxImage.Error);
                return; //early return, ko cần viết else
            }

            //6. COI NHƯ ĐÃ CHẶN TỪ KO GÕ, SAI ACCOUNT, MANAGER CHẶN LUÔN RỒI
            //   CÒN LẠI ĐANG LÀ STAFF VÀ ADMIN MÀ THOY
            //   MỞ MÀN HÌNH MAIN LÊN: DISABLE NÚT BẤM NẾU LÀ STAFF, ĐỔI CÂU HELLO CHO HỢP FULLNAME
            MainWindow main = new();
            main.AuthenticatedUser = acc; //GỬI ACC VỪA LOGIN THÀNH CÔNG SANG KIA LÀM BIẾN PHẤT CỜ - MODE NÀO???
            main.Show();
            this.Hide();  //show Main và ẩn Login phía sau
        }
    }
}
