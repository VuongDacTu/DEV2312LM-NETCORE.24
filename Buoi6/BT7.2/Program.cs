using BT7._2;



try
{

    SinhVien sinhVien = new SinhVien(1,"A");
    object b = sinhVien;
    ConBo cb = (ConBo)b;
    Console.WriteLine(cb);
}
catch (InvalidCastException ex)
{ Console.WriteLine(ex.Message); }
try
{
    int[] a = { 1, 2, 3 };
    int b = Console.Read();
    for(int i = 0;i<b;i++) Console.WriteLine(a[i]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    string type = string.Empty;
    object[] array = (object[])("here|comes|an|error".Split('|'));
    type = array.GetType().Name;
    array[0] = new object();
    Console.WriteLine(string.Format("{0}, {1}", type, string.Join(" ", array)));
}
catch(ArrayTypeMismatchException ex)
{
    Console.WriteLine(ex.Message);
}