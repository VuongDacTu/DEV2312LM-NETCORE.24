using Lab8._3;
using System.ComponentModel.DataAnnotations;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
string[] words =
{
    "Chỉ" , "trích","phê","phán","người","khác",
    "giống","như","con","chim","bồ","câu","đưa",
    "thư","bao","giờ","cũng","quay","về","nơi",
    "xuất","phát"
};
List<Film> ListFilm = new List<Film>()
{
    new Film("F01","Điệp viên 007",120000),
    new Film("F02","Tam quốc diễn nghĩa",130000),
    new Film("F03","Thiếu lâm truyền kỳ",16000),
    new Film("F04","Người nhện 2",100000),
    new Film("F05","Ngân hàng tình yêu",340000),
    new Film("F06","Người đẹp và quái thú",230000),
    new Film("F07","Biệt động Sài Gòn",190000),

};
// Lọc các số chẵn
IEnumerable<int> qnumber = numbers.Where(n => n%2 == 0);
Show<int>(qnumber, "Lọc các số chẵn");
// lọc các từ có độ dài > 4
IEnumerable<string> qword = words.Where(w => w.Length > 4);
Show<string>(qword, "Lọc các từ có độ dài > 4");
// lọc các từ có tên bắt đầu bằng chữ t
IEnumerable<string> qT = words.Where(w => w.StartsWith("t"));
Show<string>(qT, "Lọc các từ có tên bắt đầu bằng chữ t");
// Lọc các số duy nhất trong tập số
IEnumerable<int> qUnique = numbers.Distinct();
Show<int>(qUnique, "Lọc các số duy nhất trong tập số");
//Đếm xem có bao nhiêu từ không trùng nhau
int countDistinct = words.Distinct().Count();
Console.WriteLine("Đếm xem có bao nhiêu từ không trùng nhau:" + countDistinct);
// Lấy 4 số đầu tiên trong dãy
var fourNum = numbers.Take(4);
Show<int>(fourNum, "Lấy 4 số đầu tiên trong dãy");
// Lấy 2 từ đầu tiên trong câu
var twoWord = words.Take(2);
Show<string>(twoWord, "Lấy 2 từ đầu tiên trong câu");
// Lấy những từ đầu tiên có chứa chữ t
var searchword = words.TakeWhile(w => w.Contains("t"));
Show<string>(searchword, "Lấy những từ đầu tiên có chứa chữ t");
// Sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 200000
var qfilm = ListFilm.OrderBy(f => f.Price).Select(x => new
{
    x.FilmID, x.FilmName,x.Price
}).ToList().TakeWhile(t => t.Price < 200000);
Console.WriteLine("Sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 200000");
foreach(var x in qfilm)
{
    Console.WriteLine(x);
}
// bỏ qua 3 phần tử đầu tiên lấy tất cả các phần tử còn lại
var skipNumber = numbers.Skip(3);
Show<int>(skipNumber, "bỏ qua 3 phần tử đầu tiên lấy tất cả các phần tử còn lại");
// bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp
var skipTakeNumber = numbers.Skip(4).Take(3);
Show<int>(skipTakeNumber, "bỏ qua 4 phần tử đầu tiên lấy 3 phần tử kế tiếp");
// bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếp (có thẻ áp dụng phân trang)
var skipTakeFilm = ListFilm.Skip(3).Take(3);
Show<Film>(skipTakeFilm, "bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếp");
// sắp xếp giảm dần, sau đó lấy các phần tử < 5
var sortNumber = numbers.OrderDescending().SkipWhile(x => x >= 5);
Show<int>(sortNumber, "sắp xếp giảm dần, sau đó lấy các phần tử < 5");

static void Show<T>(IEnumerable<T> data, string message)
{
    Console.WriteLine(message);
    foreach (var item in data)
    {
        Console.WriteLine(item);
    }    
}