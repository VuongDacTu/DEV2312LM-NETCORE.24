using Lab6._3;

Student[] sts =
{
    new Student{Id = "S10",FirstName="Nguyen Thu",LastName="Phuong",Avg=9.5},
    new Student{Id = "S12",FirstName="Tran Thi",LastName="Thuy",Avg=9.5},
    new Student{Id = "S13",FirstName="Le Hoang",LastName="Nhat",Avg=9.5},
    new Student{Id = "S14",FirstName="Nguyen Van",LastName="Phong",Avg=9.5},
    new Student{Id = "S15",FirstName="Hoang Thi",LastName="Hue",Avg=9.5},
    new Student{Id = "S16",FirstName="Nguyen Tien",LastName="Tung",Avg=9.5},
    new Student{Id = "S17",FirstName="Nguyen Thien",LastName="Nhan",Avg=9.5},
   
};
List<Student> list = new List<Student>();
list.AddRange(sts);
// in ra ds
Console.Write("Danh sach sinh vien:");
foreach(var st in list)
{
    Console.WriteLine(st);
}
// tìm sinh viên có điểm trung bình cao nhất
double max = list[0].Avg;
Student stmax = list[0];
Console.Write("Sinh vien co diem cao nhat la:");

foreach (var st in list)
{
    if (st.Avg > max)
    {
        max = st.Avg;
        stmax = st;
    }
}

Console.Write("Sinh vien co diem cao nhat la: " +stmax);
