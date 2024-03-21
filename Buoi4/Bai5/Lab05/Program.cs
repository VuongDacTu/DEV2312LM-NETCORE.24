using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] a = { 2, 5, 1, 3, 5, 7, 5, 3, 8, 9 };
int min = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (min > a[i]) min = a[i];
}    
Console.WriteLine("min = "+min);
Array.Reverse(a);
foreach (int i in a) Console.Write(i + "\t");
Console.WriteLine();
Array.Sort(a);
Console.WriteLine("Sắp xếp tăng dần:");
foreach (int i in a) Console.Write(i + "\t");
Console.WriteLine();
Array.Reverse(a);
Console.WriteLine("Sắp xếp giảm dần:");
foreach (int i in a) Console.Write(i + "\t");
Console.WriteLine();

Console.WriteLine("Các số nguyên tố là:");

foreach (int i in a)
{
    int demsont = 0;
    for (int j = 1; j <=i; j++)
    {
        if (i % j == 0) demsont++;
    }
    if (demsont == 2) Console.Write(i + "\t");
}
Console.WriteLine();
float tbc;
int tong = 0;
foreach (int i in a) if(i>0) tong += i;
tbc = tong / a.Length;
Console.WriteLine("Trung bình cộng là: " + tbc);
int kt1 = 0, kt2=0;
foreach (int i in a)
{
    if (i % 2 == 0 && i > 0) kt1 = 1;
    else { kt1 = 0; break; }
    if (i % 2 != 0 && i < 0) kt2 = 1;
    else { kt1 = 0; break; }
}
foreach (int i in a)
{
    if (i % 2 == 0 && i < 0) kt1 = 1;
    else { kt1 = 0; break; }
    if (i % 2 != 0 && i > 0) kt2 = 1;
    else { kt1 = 0; break; }
}
if (kt1 == 1 && kt2 == 1) Console.WriteLine("Mang chua cac phan tu am duong dan xen");
else Console.WriteLine("Mang khong chua cac phan tu am duong dan xen");