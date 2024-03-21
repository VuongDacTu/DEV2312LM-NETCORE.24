using Lab3._3;
// tạo đối tượng
StudenModel action = new StudenModel();
// gọi phương thức lấy tất cả sinh viên
List<Student> listAll = action.GetStudents();
// hiển thị
foreach(var item in listAll)
{
    item.Display();
}
// gọi phương thức lấy sinh viên theo id
Student st = action.GetStudents(2);
st.Display();
// gọi phương thức lấy sinh viên có tuổi từ 25 -> 30
List<Student> listage = action.GetStudents(25, 30);
// hiển thị 
foreach(var item in listage) item.Display();
