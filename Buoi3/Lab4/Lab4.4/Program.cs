using Lab4._4;

IPerson staff = new Staff();
object data = "Bach Khoa Aptech";
staff.Insert(data);
staff.Delete(data);
staff.Update(data);
staff.Display(data);


IPerson student = new Student() { Id = "S10", Name = "CHUNGGLD",Age = 20};
student.Display(student);