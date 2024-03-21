using Lesson05_ArrayListObject;
using System.Collections;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("ArrayListObject");
ArrayList arr = new ArrayList();
arr.Add(new Student(111, "tu", 22));
Student[] sts =
{
    new Student(222,"chung",40),
    new Student(333,"tung",20),
    new Student(444,"huong",20),

};
arr.AddRange(sts);
PrintObject(arr);

//sắp xếp
//sắp xếp theo tuổi
arr.Sort(new SortAgeASC());
PrintObject(arr);
// sắp xếp theo tên
arr.Sort(new SortNameASC());
PrintObject(arr);






/// <summary>
/// Hashtable:
/// </summary>

Hashtable ht = new Hashtable();
Student st1 = new Student(123, "TuTu", 12);
ht.Add(st1.Id, st1);
Console.WriteLine("List key");
foreach (var item in ht)
{
    Console.WriteLine(item.ToString());
}
















static void PrintObject(ArrayList arr)
{
    Console.WriteLine("Danh sách sinh viên:");
    foreach (Student student in arr)
    Console.WriteLine(student.ToString());
}



class SortAgeASC : IComparer
{
    public int Compare(object x, object y)
    {
        Student a = x as Student;
        Student b = y as Student;
        return a.Age - b.Age;
    }
}
class SortNameASC : IComparer
{
    public int Compare(object x, object y)
    {
        Student a = x as Student;
        Student b = y as Student;
        return a.Name.CompareTo(b.Name);
    }
}