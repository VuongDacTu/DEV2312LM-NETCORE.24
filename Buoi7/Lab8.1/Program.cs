string[] data = { "To", "ve", "hon", "nguoi", "thi", "nguoi", "se", "tro",
"thanh", "ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi", "thi", "nguoi",
"se", "la", "ban", "cua", "ta"};
IEnumerable<string> result1 = from m in data select m;
foreach(var i in result1)
{
    Console.Write(i+" ");
}
// truy vấn có đk
IEnumerable<string> result2 = from m in data where m.Equals("nguoi") select m;
Console.WriteLine();
foreach (var i in result2)
{
    Console.Write(i + " ");
}
// truy vấn sắp xếp
Console.WriteLine();

IEnumerable<string> result3 = from m in data orderby m select m;
foreach (var i in result3)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// lấy tập dữ liệu mới
var result4 = from m in data select new { Thuong = m.ToLower(),Hoa = m.ToUpper()};

foreach (var i in result4)
{
    Console.WriteLine(i.Thuong + ":" + i.Hoa);
}