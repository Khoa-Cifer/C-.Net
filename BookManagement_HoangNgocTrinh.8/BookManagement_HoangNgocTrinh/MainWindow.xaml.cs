using AirConditioner.DAL.Models;
using AIrConditioner.BLL.Services;
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

namespace BookManagement_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AirConService _airConService = new AirConService();
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookListDataGrid.ItemsSource = _airConService.GetAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookDetailWindow detail = new BookDetailWindow();
            detail.ShowDialog(); //mở màn hình trắng để user nhập data mới

            //refresh data grid sau khi tạo mới
            FillDataGrid(_airConService.GetAll());
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //I. Phát hiện user đã click 1 dòng máy lạnh hay chưa trong grid
            //II. CHưa click mà bấm edit -> warning và không làm gì cả
            //III. Rồi, ta phải chuyển thằng vừa select trong grid sang màn hình detail, gọi là AirConditioner selectedAirConditioner;
            //IV. Mở màn hình detail (.showDialog();)
            //V. Chờ màn hình detail đóng lại (Giả sử user có sửa và save), ta Refresh lại trang, Grid, do data được sửa trong db nên cần load lại

            AirConditionerShop selectedAirConditioner = BookListDataGrid.SelectedItem as AirConditionerShop;
            //As là toán tử ép kiểu biến object này thành object khác, thay thế cho kiểu ép truyền thống
            //(AirConditionerShop)BookListDataGrid.SelectedItem, dùng cách này, ép không được thì trả về null, được thì trỏ đến cái máy lạnh đó, trung vùng new AirCon trong ram (lúc select tất cả từ db)
            if (selectedAirConditioner == null)
            {
                MessageBox.Show("Please select an air-con before editing", "Select one",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
                //nếu không chọn thì ta cảnh báo, thoát luôn, có gì đâu mà edit
            }

            //Ngược lại là mình chọn 1 dòng, mình show thử xem có đúng dòng chọn không
            //Đang nằm trong selected chính là 1 object của class AirCon
            MessageBox.Show("You have just selected an air-con before editing" + selectedAirConditioner.AirConditionerId + " | " + selectedAirConditioner.AirConditionerName);

            //Mở màn hình detail và show lên, chờ được edit rồi save rồi reload lưới
            BookDetailWindow detailWindow = new();
            //Chuyển selectedData vào màn hình detail
            detailWindow.EditedOne = selectedAirConditioner; //Quan trọng, gửi object được chọn sang màn hình detail
            //2 biến object mà gán bằng nhau, tức là 2 chàng trỏ 1 nàng
            //selected đang trỏ vào vùng ram nào, thì EditedOne trỏ chung
            //Biến object mà bằng nhau => Pass by reference
            //Nên nhớ, tạo mới object bắt buộc phải xuất hiện toán tử new.
            //Mọi sự chạm biến object mà không dùng new đều là new cũ, object cũ đã được new rồi.
            detailWindow.ShowDialog();
            FillDataGrid(_airConService.GetAll());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //Bắt xem đã chọn dòng hay chưa, chưa thì warning, rồi thì show confirm, hỏi yes/no, Yes thì xoá, xoá xong thì cũng refresh grid
            AirConditionerShop selectedAirConditioner = BookListDataGrid.SelectedItem as AirConditionerShop;
            if (selectedAirConditioner == null)
            {
                MessageBox.Show("Please select an air-con before deleting", "Select one",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            //Nếu chọn rồi thì confirm xoá hay không
            MessageBoxResult answer = MessageBox.Show("Are you sure about that ?", "Confirm ?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
            {
                return;
            }
            //Yes thì, nhờ service, xoá object đã được chọn, chính là xoá cái selectedAirCon.
            //Gọi service
            _airConService.DeleteAirConditioner(selectedAirConditioner); //xoá xong, refresh lại grid, gọi lài grid
            FillDataGrid(_airConService.GetAll());
        }

        //Ta thấy refresh grid, đổ data vào grid được dùng nhiều lần, load cửa sổ, create, update, delete -> Tách việc refresh thành 1 hàm để dùng cho nhiều hàm khác nhau, để code rõ ràng hơn -> Helper - hàm trợ giúp
        private void FillDataGrid(List<AirConditionerShop> airConditions)
        {
            BookListDataGrid.ItemsSource = null; //Xoá grid
            BookListDataGrid.ItemsSource = airConditions;
        }
    }
}