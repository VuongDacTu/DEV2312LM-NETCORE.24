// tạo đối tượng contact với constractor không tham số
using Lab3._2;

Contact ct1 = new Contact();
// gán giá trị cho ct1
ct1.Id = 1;
ct1.firstname = "Nguyen Thi";
ct1.lastname = "Hoa";
ct1.address = "Ha Noi";
ct1.phone = "0963681741";
ct1.email = "dactu3@gmail.com";
// tạo đối tượng contact với constractor có tham số
Contact ct2 = new Contact(2,"Tran Thi", "Linh", "Tuyen Quang", "0974638463","tuz041102@gmail.com");
// hiển thị thông tin ct1 và ct2
ct1.Display();
ct2.Display();
