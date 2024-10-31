using AIrConditioner.BLL.Services;
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

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for BookDetailWindow.xaml
    /// </summary>
    public partial class BookDetailWindow : Window
    {
        //Class detail cần đến 2 service, service chính dành cho AirConditioner và 1 service dành cho Supplier
        private AirConService _aiConService = new();
        private SupplierService _supplierService = new();

        public BookDetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //1. Đổ toàn bộ supplier vào combobox
            //2. Nếu là create mode, thì thôi, màn hình không có data cho user tạo máy lạnh mới
            //3. Nếu là edit mode thì phải lấy data của air con được chọn đưa vào, lấy các props của selected đổ vào các ô text, text = cái cần đổ, ID, name, bảo hành, giá tiền,.... là những info của máy lạnh được chọn
            //3.1 Nhảy đến cái supplier tương ứng cảu máy lạnh đang được edit, máy lạnh selected đang edit thuộc mitsubishi ở vị trí thứ 3, thì combobox phải hiện mitsubishi

            BookCategoryIdComboBox.ItemsSource = _supplierService.GetAllSuppliers();
            //Mặc định show hết các cột, dưới dạng toString() này là object loại gì, vậy ta chỉ cần show 1 cột, 1 cột để lấy khoái ngoại
            BookCategoryIdComboBox.DisplayMemberPath = "SupplierName";
            BookCategoryIdComboBox.SelectedValuePath = "SupplierId";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Check combobox xem user chọn và id có đứng không, chọn gì thì giả trị trả về là selectedValuePath
            MessageBox.Show("You selectd: " + BookCategoryIdComboBox.SelectedValue);
        }
    }
}
