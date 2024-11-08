using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.BLL.Services
{
    public class BookCategoryService
    {
        private BookCategoryRepository _repository = new();

        public List<BookCategory> GetBookCategories()
        {
            return _repository.GetAll();
        }
    }
}
