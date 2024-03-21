byte[] a = new byte[5];
try
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("a[{0}]=", i );
        a[i] = Convert.ToByte(Console.ReadLine());
    }
}
catch(FormatException ex)
{
    Console.WriteLine("Khong nhap duoc ki tu mang so");
}
catch(OverflowException ex)
{
    Console.WriteLine("Khong nhap duoc gia tri nam ngoai mien 0-255");
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Loi vuot qua pham vi cua mang");
}
Console.WriteLine("Noi dung mang:");
for(int i = 0;i < 5;i++)Console.WriteLine("{0}" , a[i]);