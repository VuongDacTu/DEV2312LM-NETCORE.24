using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }
        public List<Book> GetBookList() {
            List<Book> books = new List<Book>() {
                new Book() {
                    Id = 1,
                    Title="Chí Phèo",
                    AthorId=1,
                    GenreId=1,
                    Image="/imgs/Avatar/P63952.jpg",
                    Price= 550000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 2,
                    Title="Lão Hạc",
                    AthorId=2,
                    GenreId=1,
                    Image="/imgs/Avatar/P67687.jpg",
                    Price= 500000,
                    Sumary = "",
                    TotalPage = 200
                },
                new Book() {
                    Id = 3,
                    Title="Conan",
                    AthorId=2,
                    GenreId=2,
                    Image="/imgs/Avatar/P67821.jpg",
                    Price= 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book() {
                    Id = 4,
                    Title="Đường Xưa",
                    AthorId=3,
                    GenreId=4,
                    Image="/imgs/Avatar/P67842.jpg",
                    Price= 600000,
                    Sumary = "",
                    TotalPage = 300
                },
                new Book() {
                    Id = 5,
                    Title="Tắt Điện",
                    AthorId=4,
                    GenreId=3,
                    Image="/imgs/Avatar/P67848.jpg",
                    Price= 580000,
                    Sumary = "",
                    TotalPage = 240
                }
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(x => x.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>() 
        {
            new SelectListItem{Value = "1",Text="Nam Cao"},
            new SelectListItem{Value = "2",Text="Ngô Tất Tố"},
            new SelectListItem{Value = "3",Text="AdamKhoom"},
            new SelectListItem{Value = "4",Text="Thiên sư Thích Nhất Hạnh"},

        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem{Value = "1",Text="Truyện tranh"},
            new SelectListItem{Value = "2",Text="Văn học đương đại"},
            new SelectListItem{Value = "3",Text="Phật học phổ thông"},
            new SelectListItem{Value = "4",Text="Truyện cười"},

        };
    } 
}
