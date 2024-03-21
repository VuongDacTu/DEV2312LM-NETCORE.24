namespace Lesson04.Lab.Models
{
    public class DataLocal
    {
        public static List<People> _people = new List<People>() 
        {
            new People {
                Id = 0, Name = "Devmaster" , Email = "devmaster@gmail.com",
                Phone = "0283748393", Address= "25 Vũ Ngọc Phan", 
                Avatar = "images/avatar/1.jpg", Birthday = Convert.ToDateTime("2012/09/22"),
                Bio = "Viện công nghệ devmaster", Gender = 0
            },          new People {
                Id = 1, Name = "Nguyễn Thị A" , Email = "A@gmail.com",
                Phone = "0928473843", Address= "47 Thái Hà",
                Avatar = "images/avatar/2.jpg", Birthday = Convert.ToDateTime("1979/05/25"),
                Bio = "devmaster Academy", Gender = 1
            },            new People {
                Id = 2, Name = "Hoàng Thị B" , Email = "B@gmail.com",
                Phone = "0934563533", Address= "Gia Lâm, Hà Nội",
                Avatar = "images/avatar/3.jpg", Birthday = Convert.ToDateTime("1999/02/12"),
                Bio = "Viện công nghệ devmaster", Gender = 1
            },            new People {
                Id = 3, Name = "Vương Đắc Tú" , Email = "Tu@gmail.com",
                Phone = "0934567354", Address= "30 Trần Đại Nghĩa",
                Avatar = "images/avatar/4.jpg", Birthday = Convert.ToDateTime("2000/02/02"),
                Bio = "Viện công nghệ devmaster", Gender = 0
            },            new People {
                Id = 4, Name = "Trần Văn Vịt" , Email = "V@gmail.com",
                Phone = "0994837362", Address= "Ba Đình, Hà Nội",
                Avatar = "images/avatar/5.jpg", Birthday = Convert.ToDateTime("1997/12/12"),
                Bio = "Viện công nghệ devmaster", Gender = 0
            },          new People {
                Id = 5, Name = "Trần Thị B" , Email = "B02@gmail.com",
                Phone = "0934563533", Address= "8 Quang Trung, Hà Đông",
                Avatar = "images/avatar/3.jpg", Birthday = Convert.ToDateTime("1997/02/12"),
                Bio = "Viện công nghệ devmaster", Gender = 1
            },
        };
        public static List<People> GetPeoples()
        {
            return _people;
        }
        public static People? GetPeopleById(int id)
        {
            var people = _people.FirstOrDefault(p => p.Id == id);
            return people;
        }
    }
}
