using Lesson05_ListDemo;

Console.WriteLine("List Generic..........");
List<int> list = new List<int>();
list.Add(1);
list.Add(12);
list.Add(15);
list.Add(14);
Console.WriteLine("\n============DS");
foreach (int i in list)
    Console.Write(i+"\t");
// tăng
list.Sort();
Console.WriteLine("\n============DS");
foreach (int i in list)
    Console.Write(i + "\t");
// giảm
list.Sort((x , y)=>{ return y - x; });
Console.WriteLine("\n============DS");
foreach (int i in list)
    Console.Write(i + "\t");


//Object
List<Student> sts = new List<Student>()
{
    new Student(222,"chung",40),
    new Student(333,"tung",20),
    new Student(444,"huong",20),
};

Console.WriteLine("\n============DS");
foreach (var i in sts)
    Console.WriteLine(i.ToString());