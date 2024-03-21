int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
// duyet mang va in
Console.WriteLine("Cac phan tu cua mang");
for (int i = 0; i < m.Length; i++) Console.Write(m[i] +"\t");
Console.WriteLine();
int max = m[0];
foreach(int i in m)
{
    if (i > max) max = i;
}
Console.WriteLine("Phan tu lon nhat la: " + max);
// kiem tra mang co doi xung k
bool kt = true;
for (int i = 0;i < m.Length / 2; i++)
{
    if (m[i] != m[m.Length - 1 - i])
    {
        kt = false;
        break;
    }
}
if (kt) Console.WriteLine("Mang doi xung");
else Console.WriteLine("Mang khong doi xung");