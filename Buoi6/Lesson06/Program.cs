using Lesson06;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<imployees> emp = new List<imployees>()
{
    new imployees(1,"Nguyễn Văn A","01294930495",24593.5),
    new imployees(2,"Nguyễn Văn B","01294930496",24593.2),
    new imployees(3,"Nguyễn Văn C","01294930497",24593.3)
};
Console.WriteLine("DS nhân viên");
foreach (var e in emp)
    Console.WriteLine(e.ToString());
emp.Sort((x,y) => { return x.EmpSalary.CompareTo(y.EmpSalary); });
Console.WriteLine("DS nhân viên");
foreach (var e in emp)
    Console.WriteLine(e.ToString());