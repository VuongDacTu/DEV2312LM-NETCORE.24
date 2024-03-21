using System.Collections;

Hashtable pb = new Hashtable();
pb.Add(1, "Monday");
pb.Add(2, "Tuesday");
pb.Add(3, "Wednesday");
pb.Add(4, "Thursday");
pb.Add(5, "Friday");
pb.Add(6, "Saturday");
pb.Add(7, "Sunday");
if (!pb.Contains("Tuesday"))
{
    Console.WriteLine("K tim thay");
}
else Console.WriteLine("Tim thay");

foreach (int key in pb.Keys)
{
    Console.WriteLine(key + "---" + pb[key]);
}
Console.ReadKey();




