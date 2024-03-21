using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    internal class StudenModel
    {
        // khai báo danh sách tập hợp chứa các sinh viên
        List<Student> students;
        // phương thức khởi tạo
        public StudenModel() 
        {
            // khởi tạo danh sách sinh viên
            this.students = new List<Student> {
            new Student() { Id = 1, Name = "Dung", Age = 20 },
            new Student() { Id = 2, Name = "Tuan", Age = 25 },
            new Student() { Id = 3, Name = "Ha", Age= 18 },
            new Student() { Id = 4, Name = "Anh", Age = 30 },
            new Student() { Id = 5, Name = "Long", Age = 24 },
            };
        }
        #region
        // các phương thức overloading
        // phương thức trẻ về danh sách sinh viên
        public List<Student> GetStudents()
        {
            return students;
        }
        // phương thức trả về sinh viên theo id
        public Student GetStudents(int id)
        {
            Student st = null;
            foreach (var item in students)
            {
                if (item.Id == id)
                {
                    st = item;
                }

            }
            return st;
        }
        // phương thức trả về danh sách sinh viên có tuổi từ x to y
        public List<Student> GetStudents(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in students)
            {
                if(item.Age >=x && item.Age <=y) result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
