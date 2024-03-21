using BT3._2;


Book book = new Book("tu", 30, "ISO102", "Khong co gi!");

Console.WriteLine("pess 1 to flipPageBackward \npress 2 to flipPageForward \npress 3 to Display");


do
{
    int luachon = Convert.ToInt32(Console.ReadLine());
    if (luachon == 1) book.flipPageBackward();
    else if (luachon == 2) book.flipPageForward();
    else if (luachon == 3) book.Display();
    else Console.WriteLine("Khong hop le!");

}
while (book.currentPage >= 1 && book.currentPage <= book.pages);
if (book.currentPage < 1 || book.currentPage > book.pages)
{
    Console.WriteLine("So trang k ton tai!");
}