using BT6._1;
using System.Collections;
List<Book> books = new List<Book>()
{
    new Book(1,"T","Tu","Kim Dong",1992,23.4),
    new Book(2,"A","Tung","Kim Dong",2014,23.4),
    new Book(3,"B","Tuan","Nhi Dong",1992,25.4),
    new Book(4,"C","Cuong","Kim Dong",2014,26),
    new Book(5,"D","Dung","Nhi Dong",1992,23.5),
    new Book(6,"E","Yen","Kim Dong",1992,21.6),
    new Book(7,"F","Trang","Kim Dong",2014,23.4),
    new Book(8,"G","Giang","Kim Dong",1992,21.6),
    new Book(9,"H","Hoang","Kim Dong",1992,23.4),
    new Book(10,"I","Mai","Kim Dong",1992,23.4),
};

books.Sort((x, y) => { return (x.Price.CompareTo(y.Price)); });

foreach (var item in books)
{
    Console.WriteLine(item);
}

Console.WriteLine("Nhap vao ten sach muon tim:");
string a = Console.ReadLine();
foreach (Book book in books)
{
    if (book.Title == a) Console.WriteLine("Sách có title {0} là: {1}", a, book);
}
foreach (Book book in books)
{
    if (book.Year == 2014) Console.WriteLine("Sách có năm xuất bản 2014 là: " + book);
}
int demsopt = books.Count;
for (int i = 0; i < demsopt; i++)
{
    if (books[i].Publisher.IndexOf("Nhi Dong") > -1)
    {
        books.RemoveAt(i);
        Console.WriteLine(i);
        i--;
        demsopt--;
    }

}


foreach (var item in books)
{
    Console.WriteLine(item);
}

Console.ReadKey();








