using BT8._1;

static void Show<T>(IEnumerable<T> data, string message)
{
    Console.WriteLine(message);
    foreach(var item in data)
    {
        Console.WriteLine(item);
    }
}
Book[] books =
{
    new Book(1, "a","tu",6000,"kim dong" ,"2015"),
    new Book(2, "b","tung",3000,"nhi dong" ,"2016"),
    new Book(3, "c","tuan",1500,"kim dong" ,"2017"),
    new Book(4, "Lập trình C","thinh",7000,"nhi dong" ,"2012"),
    new Book(5, "e","trang",1200,"kim dong" ,"2012"),
    new Book(6, "Lập trình Java","hung",600,"nhi dong" ,"2013"),
    new Book(7, "g","my",4000,"kim dong" ,"2015"),
    new Book(8, "h","anh",2000,"kim dong" ,"2015"),
    new Book(9, "i","thuyen",1900,"nhi dong" ,"2015"),
    new Book(10, "k","son",1100,"kim dong" ,"2014"),
};
IEnumerable<Book> ALLbooks = from b  in books select b;
Show<Book>(ALLbooks, "Tat ca cac quyen sach");
var Pbooks = ALLbooks.Where(b => b.price >= 1000 && b.price <= 5000).ToList();
Show<Book>(Pbooks, "Nhung quyen sach co gia tu 1000 - 5000");
var Ybooks = ALLbooks.Where(b => b.year.Equals("2015"));
Show<Book>(Ybooks, "Nhung quyen sach xuat ban nam 2015");
var Abooks = ALLbooks.Where(b => b.year.StartsWith("Lập trình"));
Show<Book>(Abooks, "Nhung quyen sach có tên Lập trình");

