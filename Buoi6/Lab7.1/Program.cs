using Store;

Supply.Manufacturer dealer = new Supply.Manufacturer();
dealer.Name = "Coca cola";
dealer.Email = "cocacolap@gmail.com";
dealer.Phone = "(111)791-8074";
Console.WriteLine("Dealer information");
Console.WriteLine("\tName: " + dealer.Name);
Console.WriteLine("\tEmail: " + dealer.Email);
Console.WriteLine("\tPhone: "+dealer.Phone);
StoreItem si = new StoreItem();
si.ItemNo = 1;
si.ItemName = "Fanta";
si.Price = 80.00M;
Console.WriteLine("Store Inventory");
Console.WriteLine("\tItem #: " + si.ItemNo);
Console.WriteLine("\tItem Name: " + si.ItemName);
Console.WriteLine("\tUnit Price: " + si.Price);





Console.ReadKey();