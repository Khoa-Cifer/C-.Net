using BookManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.Books.Include(b => b.BookCategory).ToList();
        }

        public void DeleteBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public List<Book> SearchBooks(string name, string description)
        {
            _context = new();
            if (description.Length == 0 && name.Length == 0) 
            {
                return _context.Books.Include(b => b.BookCategory).ToList();
            }
            else if (description.Length == 0)
            {
                return _context.Books.Where(u => u.BookName.Contains(name)).Include(u => u.BookCategory).ToList();

            }
            else if (name.Length == 0)
            {
                return _context.Books.Where(u => u.Description.Contains(description)).Include(u => u.BookCategory).ToList();
            }
            return _context.Books.Where(u => u.BookName.Contains(name) || u.Description.Contains(description)).Include(u => u.BookCategory).ToList();
        }
    }
}
