
SortedList<string, string> listEm = new SortedList<string, string>();
// đưa dữ liệu vào
listEm.Add("E01", "Tran Thi Thuy");
listEm.Add("E02", "Le Hai Ha");
listEm.Add("E03", "Nguyen Van Hung");
listEm.Add("E04", "Hoang Thi Thom");
listEm.Add("E05", "Trinh Van Chien");
// in ra ds
Console.WriteLine("Danh sach nhan vien:");
foreach (string key in listEm.Keys)
    Console.WriteLine(key + "---" + listEm[key]);

// tìm kiếm tất cả nhân viên có tên bắt đầu bằng chữ th
Console.WriteLine("Danh sach nhan vien co ten bat dau bang chu th");
foreach (string key in listEm.Keys)
{
    if (listEm[key].StartsWith("Th")) 
    Console.WriteLine(key + "---" + listEm[key]);
}
Console.WriteLine();
//xoá nhân viên có mã E04
listEm.Remove("E04");
foreach (string key in listEm.Keys)
    Console.WriteLine(key + "---" + listEm[key]);
Console.WriteLine();
// Kiểm tra nếu chưa có nhân viên E06 thì thêm vào
if (!listEm.ContainsKey("E06")) listEm.Add("E06", "Nguyen Hoai Linh");
foreach (string key in listEm.Keys)
    Console.WriteLine(key + "---" + listEm[key]);