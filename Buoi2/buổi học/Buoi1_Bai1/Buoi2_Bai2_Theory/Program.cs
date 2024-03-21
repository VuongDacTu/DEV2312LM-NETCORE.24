using Buoi2_Bai2_Theory;
using System.Runtime.InteropServices;

Console.WriteLine("Demo!!!--------------------------");
// Khởi tạo đối tượng
Category category = new Category(111,"Devmaster");
// Truy cập đén thuộc tính

category.Display();
///
Console.WriteLine("Employess !!!--------------------");
Employees employees = new Employees();
employees.Id = 1;
employees.FullName = "Test";
employees.Salary = 10.56;
employees.PrintInfor();
// Tạo trong employees -> hàm khởi tạo có
// 3 tham số

// test caculator
// sử dụng phương thức tính
int kq = caculator.Add(10, 20);
Console.WriteLine(kq);
kq = caculator.Sub(10, 20);
Console.WriteLine(kq);
caculator caculator2 = new caculator();
kq = caculator2.Mul(10, 20);
Console.WriteLine(kq);
// ref / out
int cong, tru;
caculator2.Calc(10,20, out cong, out tru);
Console.WriteLine("cong: " + cong);
Console.WriteLine("tru: "+  tru);

int num1 = 100, num2 = 200;
Console.WriteLine("Num1: {0} / Num2: {1}", num1, num2);
caculator2.Swap(num1, num2);
Console.WriteLine(" Swap => Num1: {0} / Num2: {1}", num1, num2);
caculator2.Swapref(ref num1, ref num2);
Console.WriteLine(" Swap(ref) => Num1: {0} / Num2: {1}", num1, num2);
