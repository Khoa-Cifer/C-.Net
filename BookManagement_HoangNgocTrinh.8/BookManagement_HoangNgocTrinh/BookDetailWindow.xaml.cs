using AirConditioner.DAL.Models;
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
        private AirConService _airConService = new();
        private SupplierService _supplierService = new();
        //Màn hình detail có 2 mode: Mode edit và create
        //Create thì chỉ là load màn hình lên, có thêm combobox có sẵn các supplier, mình chọn default là supplier đầu tiên
        //Mode edit là màn hình sẽ được fill đầy info vào các ô text
        //Info này lấy từ object selected gửi từ main
        //Bên main có biến AirCon selected = trỏ sẵn đến dòng được select, bên màn hình này phải trỏ vào biến selected bên kia, trỏ được thì chấm từng Property của selected để đổ vào các ô text, vậy bên màn hình detail, ta cần khai báo 1 biến style kiểu AirCon, AirCon x = selected (Biến AirCon bên main), để sờ được biến thì x phải là public để ta .x = selected
        //Nó là hình thức của hàm Set()
        //Do đó bên detail này ta khai báo 1 property kiểu AirCon
        public AirConditionerShop EditedOne { get; set; }
        //Đây là 1 prop hứng cái selected bên main vì chúng đều là AirCon
        //Vì đều là 1 prop, nên khi new màn hình detail, new class Detail mà không nói gì cả, thì thằng này mang giá trị null default;
        //Nếu giá trị của nó là null, thì ta đang ở create mode
        //Còn nếu ta set nó = selected khi ta new, tức là ta đang ở edit mode
        //Biến EditedOne là biến flag, dùng để kiếm soát state, trạng thái của object
        //If EditedOne == null => Tạo mới
        //If EditedOne == selected => Update
        //Thay thế biến boolean để check create/update

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
            //Đổ các ô text lấy value từ selected chuyển sang, đang được trỏ bởi EditedOne
            //Nhớ điền data, điền đủ các ô text ứng với các cột trong table chính

            //Phải check mode edit hay create
            if (EditedOne != null)
            {
                BookIdTextBox.Text = EditedOne.AirConditionerId.ToString();
                BookNameTextBox.Text = EditedOne.AirConditionerName;
                DescriptionTextBox.Text = EditedOne.Warranty;
                QuantityTextBox.Text = EditedOne.Quantity.ToString();
                PriceTextBox.Text = EditedOne.DollarPrice.ToString();
                AuthorTextBox.Text = EditedOne.FeatureFunction;
                SoundPressureTextBox.Text = EditedOne.SoundPressureLevel;
            }

            //jump đến đúng value của combobox, ví dụ ở kiên giang thì phải select sẵn kiên giang, show data hiện có
            //Supplier y chang, nhảy đến nhà cung cấp EditOne đang có, new thì không cần, cứ chọn đầu tiên
            //Tự làm thử
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Check combobox xem user chọn và id có đứng không, chọn gì thì giả trị trả về là selectedValuePath
            //MessageBox.Show("You selectd: " + BookCategoryIdComboBox.SelectedValue);
            //Các bước xử lí: ở nút bấm này làm các việc sau
            //1. Tạo mới aircon object, thu nạo các info từ ô nhập, set vào aircon
            //2. Tuỳ vào edit hay create để gọi service tưng ứng
            //3. Đóng màn hình này lại
            //4. Trở lại màn hình main và F5 grid để có info mới nhất từ DB
            //Lưu ý: validation
            //Tính validation riêng cho create, update, mặc dù 100% giống nhau, nhưng khác tính năng
            //Quantity là con số từ 100->1000, gõ chữ trong quantity, gõ chữ nằm ngoài biên
            //Lưu ý primary key có trùng hay không khi tạo mới và không cho edit khi update
            AirConditionerShop obj = new();
            //Không làm theo object initialization, vì lấy ô text rất dài, code dài, nếu gộp ngay lúc new, code khó đọc, nên set lẻ bên ngoài
            //Nó ngược lại lúc viết code đổ vào form, từ edited vào field/text
            obj.AirConditionerId = int.Parse(BookIdTextBox.Text);
            obj.AirConditionerName = BookNameTextBox.Text;
            obj.Warranty = DescriptionTextBox.Text;
            obj.Quantity = int.Parse(QuantityTextBox.Text);
            obj.DollarPrice = double.Parse(PriceTextBox.Text);
            obj.FeatureFunction = AuthorTextBox.Text;
            obj.SoundPressureLevel = SoundPressureTextBox.Text;
            obj.SupplierId = BookCategoryIdComboBox.SelectedValue.ToString();
            //Combo xổ xuống có display là show name nhưng có selected value path = cột id
            //Khi user chọn 1 dòng trong combobox, thì selectedvalue mang FK cần dùng, mang mã số của supplier, và ta đem mã số supplier, foreign key vào air-con.

            if (EditedOne == null)
            {
                _airConService.CreateAirConditioner(obj);
            } else
            {
                _airConService.UpdateAirConditioner(obj);
            }

            //Xong thì đóng lại
            this.Close(); //gọi hàm của class cha window
        }
    }
}
