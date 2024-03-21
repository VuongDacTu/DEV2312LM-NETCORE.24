// tạo đối tượng Book
using Lab5._4;

Book b = new Book("Programming with Csharp", 4);
b[0] = new Chapter("Chapter 1", "Intoduction to Csharp");
b[1] = new Chapter("Chapter 2", "DataType and Variables in Csharp");
b[2] = new Chapter("Chapter 3", "Input and Output in Console Application");
b[3] = new Chapter("Chapter 4", "Statements Conditions and Loops");
Console.WriteLine("List of book:");
Console.WriteLine(b.Name);
// danh sách chương;
for (int i = 0; i < 4; i++)
    Console.WriteLine(b[i]);

Console.WriteLine();
Console.WriteLine("Detail of Chapter 3");
Console.WriteLine(b["Chapter 3"]);
Console.Read();