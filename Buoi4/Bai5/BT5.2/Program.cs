using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[,] a = {
    {4,4,6,3},
    {5,5,4,7},
    {6,3,6,9},
    {7,2,1,3},
};
int[] b = new int[a.Length];
int dem = 0;
foreach (var i in a)
{
    
    Console.Write(i+ "\t");
    dem++;
    if (dem == 4) {Console.WriteLine(); dem = 0;}
}
Console.WriteLine("Mang:");
for(int i = 0; i <= a.GetUpperBound(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {
        Console.Write(a[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {
        if(i == j)
        Console.Write(a[i, j] + "\t");
    }
}

Console.WriteLine();
int c = 0;

for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    
    int min = a[0,c];
    
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {
        
        if (a[j, i] < min) min = a[j, i];

        
    }
    c++;
    Console.WriteLine("Phan tu nho nhat tren cot {0} là: {1}", i + 1,min);
}
Console.WriteLine("Cac phan tu chia het cho 7 la:");
for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {

        if (a[i, j] % 7 == 0) Console.Write(a[i, j] + "\t");


    }
}
Console.WriteLine();
int tong = 0;

for (int i = 0; i <= a.GetUpperBound(0); i++)
{

        
        tong += a[i, 0];
        tong += a[i, 3];
        if(i == 0 || i == 3) { tong += a[i, 1]; tong += a[i, 2]; }
 
}

Console.WriteLine("Tổng các phần tử nằm ở đường viền mảng: "+tong);
int k = 0;
for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    for (int j = 0; j <= a.GetUpperBound(1); j++)
    {

       
        b[k] = a[i, j];
        k++;
        if (k == a.Length) break;
    }

}
Console.WriteLine("mảng 1 chiều");
foreach(int i in b)
{
    Console.Write(i + ", ");
}
Console.WriteLine();
Array.Sort(b);
Console.WriteLine("Mảng 1 chiều sau khi sắp xếp:");
foreach (int i in b)
{
    Console.Write(i + ", ");
}
Console.WriteLine();
//1 3 4 5
//2 4 5 1
//1 4 4 4
//1 4 5 4






Console.Read();
