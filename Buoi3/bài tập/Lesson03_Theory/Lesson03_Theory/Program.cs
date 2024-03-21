using Lesson03_Theory;
/*
Student student = new Student();
student.Display();
student = new Student(111,"Tu",22);
student.Display();
student.ID = 222;
student.Name = "Trung";
student.Age = 45;
student.Display();
*/




/*
OverloadingDemo over = new OverloadingDemo();
int res = over.Sum(10);
Console.WriteLine("tong: 0,{0} => {1}",10,res);
res = over.Sum(0,10);
Console.WriteLine("tong: {0},{1} => {1}",0, 10, res);


double kq = over.Sum(10.1f,10.2f);
Console.WriteLine("tong: {1}", kq);
*/




//Cat cat = new Cat();
//cat.Eat();
//cat.DoSomeThing();



Staff staff = new Staff();
staff.prinInfo();
staff = new Staff(123,"Chung Chung", "25 Vu Ngoc Phan", "09738495738",123.123f, 232.23f);
staff.prinInfo();
Console.WriteLine(staff.ToString());