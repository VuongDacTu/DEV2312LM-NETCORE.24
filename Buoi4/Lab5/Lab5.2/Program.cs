int[,] a =
{
    {4,6,9 },
    {2,4, 5 },
    {9,2,6 },
    {1,6,3 }
};
// duyet mang va in theo hang cot
Console.WriteLine("Noi dung mang:");
for (int i = 0;i <= a.GetUpperBound(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < a.GetLength(1); j++) 
    Console.Write(a[i, j] + "\t");
    Console.WriteLine();
}
// Tim ra cac phan tu co chi so hang bang chi so cot
Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
for (int i = 0; i <= a.GetUpperBound(0); i++) 
{ 
    
    for (int j = 0; j < a.GetLength(1); j++)
        if(i == j)
        Console.Write(a[i, j] + "\t");
}
// Cac phan tu lon nhat tren hang
Console.WriteLine("Phan tu lon nhat tren hang:");
for (int i = 0; i <= a.GetUpperBound(0); i++)
{
    int max = a[i, 0];
    for (int j = 0; j < a.GetLength(1); j++)
        if (a[i,j] > max) max = a[i, j];
    Console.WriteLine("Phan tu lon nhat tren hang {0} la: {1}", i , max);
            
}