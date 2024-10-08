using StudentTester.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTester.Services
{
    public class Cabinet
    {
        //cái tủ có ngăn chứa đủ rộng để lưu hồ sơ sinh viên
        //Xải mảng đi kèm biến count
        private Student[] _arr = new Student[500];
        private int _count = 0;

        //Câu hỏi 1: Tại sao tui lại không làm property
        //Câu hỏi 2: Cái tủ này bị fix 500 chỗ, những ngành khác cần ít hơn, vậy đóng tủ có kích thước theo nhu cầu, làm được không
    }
}
