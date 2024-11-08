using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class BookService
    {
        private BookRepository _repository = new();

        public List<Book> GetBooks()
        {
            return _repository.GetAll();
        }

        public void AddBook(Book book)
        {
            _repository.CreateBook(book);
        }

        public void DeleteBook(Book book)
        {
            _repository.DeleteBook(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.UpdateBook(book);
        }

        public List<Book> SearchBooks(string name, string desc)
        {
            return _repository.SearchBooks(name, desc);
        }
    }
}
