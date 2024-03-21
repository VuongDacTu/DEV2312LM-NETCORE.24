using Lab6._1;
using System.Collections;

ArrayList inv = new ArrayList();
Product[] products =
{
    new Product("A",5.9,3),
    new Product("B",8.2,2),
    new Product("C",3.5,4),
    new Product("D",1.8,8),
};
inv.AddRange(products);
// in ra ds
Console.WriteLine("Product list:");
foreach (Product product in products )
    Console.WriteLine("........" + product);