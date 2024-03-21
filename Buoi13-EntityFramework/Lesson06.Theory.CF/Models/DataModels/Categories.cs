using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.Theory.CF.Models.DataModels
{
    [Table("Categories")]

    public class Categories
    {
        [
            DisplayName("Mã loại"),
            Key
            ]
        public int CategoryId { get; set; }
        [
            DisplayName("Tên loại"),
            StringLength(100)
            ]
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
