using System.Collections;
using System.Reflection.Metadata.Ecma335;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Array List Demo");
// khởi tạo collection ArrayList
ArrayList arr = new ArrayList();
// properties
Console.WriteLine("Count:" + arr.Count);
Console.WriteLine("Capacity:" + arr.Capacity);
Console.WriteLine("=====================");
//Method
arr.Add("Xin chào");
arr.Add(100);
Console.WriteLine("Count:" + arr.Count);
Console.WriteLine("Capacity:" + arr.Capacity);
Console.WriteLine("=====================");
arr.Insert(1, "devmaster");
printArrayList(arr);
Console.WriteLine();
string[] names = { "tùng", "cúc", "trúc", "mai" };
arr.AddRange(names);
Console.WriteLine("Count:" + arr.Count);
Console.WriteLine("Capacity:" + arr.Capacity);
Console.WriteLine("=====================");
printArrayList(arr);
arr.InsertRange(0,names);
Console.WriteLine("Count:" + arr.Count);
Console.WriteLine("Capacity:" + arr.Capacity);
Console.WriteLine("=====================");
printArrayList(arr);
arr.Remove("tùng");


printArrayList(arr);
arr.RemoveAt(1);
printArrayList(arr);
arr.Remove(100);
arr.Sort();
printArrayList(arr);
//arr.Sort(new SortDESC());
printArrayList(arr);
if (arr.Contains("cúc"))
{
    int index = arr.IndexOf("cúc");
    Console.WriteLine("Tìm thấy tại:" + index);
}
else Console.WriteLine("Không tìm thấy");
static void printArrayList(ArrayList arr)

{
    Console.WriteLine("Danh sách phần tử trong mảng:");
    foreach (var item in arr) Console.WriteLine(item);
}
//class SortDESC : IComparer
//{
//    public int Comparer(object x, object y)
//    {
//        string a = x as string;
//        string b = y as string;
//        return b.CompareTo(a);
//    }
//}
