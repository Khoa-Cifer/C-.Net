using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
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

namespace BookManagement_TranDangKhoa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookService _bookService = new();
        public UserAccount AuthorizedUser { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid(_bookService.GetBooks());
            if (AuthorizedUser.Role == 2)
            {
                CreateButton.IsEnabled = false;
                UpdateButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        private void FillDataGrid(List<Book> books)
        {
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = books;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detail = new();
            detail.ShowDialog();
            FillDataGrid(_bookService.GetBooks());
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Book selected = BookListDataGrid.SelectedValue as Book;
            if (selected != null)
            {
                DetailWindow detail = new();
                detail.Selected = selected;
                detail.ShowDialog();
                FillDataGrid(_bookService.GetBooks());
            }
            else
            {
                MessageBox.Show("Please select a book");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Book selected = BookListDataGrid.SelectedValue as Book;
            if (selected != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure ?", "Select yes or no", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    _bookService.DeleteBook(selected);
                    FillDataGrid(_bookService.GetBooks());
                }
            }
            else
            {
                MessageBox.Show("Please select a book");
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string nameSearchValue = BookNameTextBox.Text;
            string descSearchValue = DescriptionTextBox.Text;
            FillDataGrid(_bookService.SearchBooks(nameSearchValue, descSearchValue));
        }
    }
}