using BookManagement.BLL.Services;
using BookManagement.DAL.Models;
using Microsoft.IdentityModel.Tokens;
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

namespace BookManagement_TranDangKhoa
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        private BookCategoryService _bookCategoryService = new();
        private BookService _bookService = new();

        public Book Selected { get; set; }

        public DetailWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookIdTextBox.IsEnabled = false;
            BookCategoryIdComboBox.ItemsSource = _bookCategoryService.GetBookCategories();
            BookCategoryIdComboBox.SelectedValuePath = "BookCategoryId";
            BookCategoryIdComboBox.DisplayMemberPath = "BookGenreType";
            if (Selected != null)
            {
                BookIdTextBox.Text = Selected.BookId.ToString();
                BookNameTextBox.Text = Selected.BookName;
                DescriptionTextBox.Text = Selected.Description;
                QuantityTextBox.Text = Selected.Quantity.ToString();
                PriceTextBox.Text = Selected.Price.ToString();
                AuthorTextBox.Text = Selected.Author.ToString();
                PublicationDateDatePicker.SelectedDate = Selected.PublicationDate;
                BookCategoryIdComboBox.SelectedValue = Selected.BookCategoryId;
            }
            else
            {
                BookCategoryIdComboBox.SelectedIndex = 0;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            bool check = true;
            string bookName = BookNameTextBox.Text;
            string description = DescriptionTextBox.Text;
            string quantity = QuantityTextBox.Text;
            string price = PriceTextBox.Text;
            string author = AuthorTextBox.Text;
            DateTime? publicationDate = null;
            try
            {
                publicationDate = (DateTime)PublicationDateDatePicker.SelectedDate;
            }
            catch
            {
                check = false;
            }
            string bookCategoryId = BookCategoryIdComboBox.SelectedValue.ToString();
            if (bookName.IsNullOrEmpty() || description.IsNullOrEmpty() || quantity.IsNullOrEmpty() || price.IsNullOrEmpty() || author.IsNullOrEmpty() || !publicationDate.HasValue)
            {
                check = false;
            }

            if (bookName.Length < 5 && bookName.Length > 90)
            {
                check = false;
            }

            string[] bookNameList = bookName.Split(" ");
            foreach (var item in bookNameList)
            {
                if (!Char.IsUpper(item[0]))
                {
                    check = false;
                }
            }

            if (check)
            {
                if (Selected != null)
                {
                    Book updatedBook = new();
                    updatedBook.BookId = Selected.BookId;
                    updatedBook.BookName = bookName;
                    updatedBook.Description = description;
                    updatedBook.Quantity = int.Parse(quantity);
                    updatedBook.Price = double.Parse(price);
                    updatedBook.Author = author;
                    updatedBook.PublicationDate = (DateTime)publicationDate;
                    updatedBook.BookCategoryId = int.Parse(bookCategoryId);
                    _bookService.UpdateBook(updatedBook);
                    this.Close();
                }
                else
                {
                    Book newBook = new();
                    newBook.BookName = bookName;
                    newBook.Description = description;
                    newBook.Quantity = int.Parse(quantity);
                    newBook.Price = double.Parse(price);
                    newBook.Author = author;
                    newBook.PublicationDate = (DateTime)publicationDate;
                    newBook.BookCategoryId = int.Parse(bookCategoryId);
                    _bookService.AddBook(newBook);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid field or some fields does not inputted");
            }
        }
    }
}
