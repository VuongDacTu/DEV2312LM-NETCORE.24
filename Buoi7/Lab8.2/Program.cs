using Lab8._2;

var customers = new Customer[]
{
    new Customer {ID = 5, Name = "Sam"},
    new Customer {ID = 6, Name = "Dave"},
    new Customer {ID = 7, Name = "Julia"},
    new Customer {ID = 8, Name = "Sue"},

};
var orders = new Oder[]
{
    new Oder {ID = 5, Product = "Book"},
    new Oder {ID = 6, Product = "Game"},
    new Oder {ID = 7, Product = "Computer"},
    new Oder {ID = 8, Product = "Shirt"},

};
// Sử dụng truy vấn và join 2 tập dữ liệu dựa trên ID
var query = from c in customers
            join o in orders on c.ID equals o.ID
            select new
            {
                c.Name,
                o.Product
            };
// hiển tị tên khách hàng và nhóm sản phẩm
foreach(var i in query)
{
    Console.WriteLine("{0} bought {1}", i.Name, i.Product);
}