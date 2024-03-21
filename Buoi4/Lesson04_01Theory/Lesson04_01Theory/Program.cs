//using Lesson04_01Theory;

//Console.WriteLine("Review!");
//Student student = new Student();
//Console.WriteLine(student.ToString());
//student = new Student(12,"Tu",22);
//student.Display();
//Console.WriteLine(student.ToString());

using Lesson04_01Theory;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
int[] a;
int[] b = new int[10];
float[] c = new float[] {10.2f,3.4f, 2.3f,2.5f};
string[] names = { "Hùng", "DŨng", "Trang", "Trong" };
// truy cập
b[0] = 100;
b[5] = 500;
b[9] = 900;
Console.WriteLine("b[5] = " + b[5]);
// Duyệt mảng
for (int i = 0;b.Length > i;i++) Console.Write("{0,-5}",b[i]);
Console.WriteLine();
foreach(var i in b)
{
    Console.Write("{0,-5}", i);
}
Console.WriteLine();
foreach (var i in names) Console.Write("{0,-15}", i);
// khởi tạo mảng đối tượg sinh viên gồm 5 đối tượng
// gán giá trị
// in tra màn hình
Console.WriteLine();
Student[] students = {
 new Student(1,"Tu",22),
 new Student(2,"Tuan",20),
 new Student(3, "Tung", 21),
 new Student(4, "hung", 22),
 new Student(5, "Dung", 23),
};
foreach (var i in students) i.Display();

for (int i = 0;i< students.Length;i++)
{
    for (int j = i+1;j < students.Length-1; j++)
    {
        if(students[i].Age > students[j].Age)
        {
            Student student = students[i];
            students[i] = students[j];
            students[j] = student;

        }

    }
}


foreach (var i in students) Console.WriteLine(i.ToString());
Console.WriteLine();


int[] arr = { 1, 7, 5, 3, 5 };
Array.Sort(arr);
foreach (var i in arr) Console.Write(i + "\t");
Console.WriteLine();
Array.Reverse(arr);
foreach (var i in arr) Console.Write(i + "\t");
Console.WriteLine();
Array.Sort(arr, (x, y) => { return y - x; });
foreach (var i in arr) Console.Write(i + "\t");
Console.WriteLine();
Array.Sort(students, (x, y) => { return y.Age - x.Age; });
foreach (var i in students) Console.WriteLine(i.ToString());
Console.WriteLine();
Console.Read();