using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
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

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private AirConService _service = new();

        //MÀN HÌNH MAIN ĐC GỌI QUA 2 ACCOUNT KHÁC NHAU: ADMIN, VÀ STAFF
        //ADMIN CỨ ĐỂ BÌNH THƯỜNG - FULL QUYỀN CÁC NÚT BẤM
        //STAFF THÌ DISABLE 3 NÚT BẤM: CREATE, UPDATE, DELETE
        //TA CẦN BIẾN FLAG ĐỂ BIẾT USER NÀO ĐANG MỞ MÀN HÌNH MAIN
        //Y CHANG MÀN HÌNH DETAIL
        //MAIN ---> TRUYỀN SELECTED ONE MÁY LẠNH --> CHO DETAIL 
        //LOGIN --- TRUYỀN ACCOUNT ĐÃ XÁC THỰC ---> CHO MAIN
        public StaffMember AuthenticatedUser { get; set; }
        //ku này sẽ đc gán từ màn hình Login, lúc new á!!!
        //.Role = 2 mày là Staff

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //1. ĐỔ LƯỚI
            AirCondDataGrid.ItemsSource = _service.GetAllMayLanh();
            //2. DISABLE NÚT BẤM NẾU LÀ STAFF
            if (AuthenticatedUser.Role == 2)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
            //3. CHỈNH LÀ MESSAGE HELLO <AI ĐÓ>
            HelloMsgLabel.Content = "Hello/Xin chào, " + AuthenticatedUser.FullName;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //1. PHÁT HIỆN XEM USER ĐÃ CLICK 1 DÒNG MÁY LẠNH HAY CHƯA TRONG GRID
            //2. CHƯA CLICK MÀ BÀY ĐẶT ĐÒI EDIT, CHỬI, KO LÀM TIẾP
            //3. RỒI, THÌ TA PHẢI CHUYỂN CÁI THẰNG VỪA BỊ SELECT TRONG GRID
            //   GIAO NÓ SANG BÊN MÀN HÌNH DETAIL, TẠM GỌI THẰNG NÀY - CÁI MÁY LẠNH BỊ CHỌN LÀ AirConditioner selected; 
            //4. MỞ MÀN HÌNH DETAIL. .ShowDialog();
            //5. CHỜ MÀN HÌNH DETAIL ĐÓNG LẠI (GIẢ SỬ USER CÓ SỬA VÀ SAVE)
            //   TA F5/RERESH, RELOAD LẠI CÁI GRID, DO DATA CÓ ĐC SỬA TRONG DB
            //   LOAD LẠI

            AirConditioner? selected = AirCondDataGrid.SelectedItem as AirConditioner;
            //toán tử as là toán tử ép kiểu, biến object này thành object khác nếu ép đc, nó thay thế cho toán tử ép kiểu truyền thống

            //(AirConditioner)AirCondDataGrid.SelectedItem, dùng ngoặc tròn
            //ép ko đc thì trả về null, đc thì trỏ đến 1 cái máy lạnh, vùng new AirCon trong ram (new lúc gọi _service.GetAllMayLanh();

            if (selected == null)
            {
                MessageBox.Show("Please select an air-con before editing", "Select one", MessageBoxButton.OK, MessageBoxImage.Stop);

                return;  //nếu ko chọn 1 dòng thì ta cảnh báo, thoát luôn, có gì mà edit
            }

            //ngược lại tức là chọn 1 dòng, mình show thử xem có đúng dòng chọn hok
            //đang nằm trong selected chính là 1 object của class AirCon
            //MessageBox.Show("Bạn vừa chọn máy lạnh: " + selected.AirConditionerId + " | " + selected.AirConditionerName);

            //mở màn hình Detail và show nó lên, chờ người ta edit rồi save rồi F5 grid bên này 
            DetailWindow detail = new();
            //CHUYỂN SELECTED SANG DETAIL
            detail.EditedOne = selected; //QUAN TRỌNG, GỬI SELECTED SANG BÊN DETAIL
            //CHÔT HẠ QUAN TRỌNG, ĐÃ HỌC: 2 BIẾN OBJECT GÁN = NHAU, TỨC LÀ 2 CHÀNG TRỎ 1 NÀNG
            //SELECTED ĐANG TRỎ AI, CHO TAO EDITEDONE CÙNG TRỎ VỚI
            //BIẾN OBJECT MÀ BẰNG NHAU, LÀ PASS BY REFERENCE
            //NÊN NHỚ, TẠO MỚI OBJECT BẮT BUỘC PHẢI XUẤT HIỆN TOÁN TỬ NEW; MỌI SỰ SỜ CHẠM BIẾN OBJECT MÀ KO CÓ CHỮ NEW -> ĐỀU LÀ NEW CŨ ĐÃ NEW SẴN RỒI!!!


            detail.ShowDialog();
            //F5 GRID
            FillDataGrid(_service.GetAllMayLanh());
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new();            
            detail.ShowDialog();  //mở màn hình trắng cho user nhập máy lẠNH MỚI

            //f5 grid sau khi tạo mới 1 máy lạnh
            FillDataGrid(_service.GetAllMayLanh());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // BẮT XEM ĐÃ CHỌN 1 DÒNG CẦN XOÁ HAY CHƯA, CHƯA THÌ CHỬI
            // RỒI THÌ CONFIRM THÊM 1 NHÁT, HỎI YES | NO, YES THÌ XOÁ
            // XOÁ XONG THÌ F5 GRID
            AirConditioner? selected = AirCondDataGrid.SelectedItem as AirConditioner;

            if (selected == null)
            {
                MessageBox.Show("Please select an air-con before deleting", "Select one", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            //nếu chọn rồi thì confirm xoá - đoạn code này 0.75 điểm
            MessageBoxResult answer = MessageBox.Show("Do you really want to delete this air-con?", "Confirm?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.No)
                return;

            //yes rồi
            //nhờ Service,  giúp tao xoá 1 object!!!!!!!!!!!!!!!!!!
            //chính là thằng selected
            _service.DeleteAirCon(selected); //xoá xong, chưa xong, phải F5 grid
            FillDataGrid(_service.GetAllMayLanh());
            
        }
        
        //TA THẤY F5 GRID, ĐỔ DATA LIST<AIR-CON> ĐC XÀI MẤY LẦN: LOAD CỬA SỔ, CREATE, UPDATE, DELETE -> TÁCH VIỆC F5 THÀNH 1 HÀM NỘI BỘ TRONG CLASS NÀY, ĐỂ DÙNG CHUNG CHO NHIỀU HÀM KHÁC, ĐỂ CODE RÕ RÀNG TỪNG KHỐI CÔNG VIỆC
        //-> HÀM HELPER - HÀM TRỢ GIÚP
        private void FillDataGrid(List<AirConditioner> arr)
        {
            AirCondDataGrid.ItemsSource = null; //xoá grid
            AirCondDataGrid.ItemsSource = arr; //gán = danh sách mới
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            //Are you sure? rảnh thì làm
            Application.Current.Shutdown();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //Ta chặn việc gõ số vào quantity trước
            int? quantity = null;

            if (!string.IsNullOrWhiteSpace(QuantityTextBox.Text))
            {
                //user có gõ vào ô quantity
                bool checkQuantity = int.TryParse(QuantityTextBox.Text, out int val);
                if (checkQuantity)
                {
                    //Gõ ok, convert được, val có giá trị int, đưa vào quantity;
                    quantity = val;
                }
                else
                {
                    //Không convert được, chửi, không search
                    MessageBox.Show("Invalid quantity. Quantity must be a positive ");
                    return; //Gõ cà chớn là kết thúc luôn
                }
            }
            List<AirConditioner> result = _service.SearchByFeatureAndQuantity(FeatureFunctionTextBox.Text, quantity);
            FillDataGrid(result);
        }
    }
}