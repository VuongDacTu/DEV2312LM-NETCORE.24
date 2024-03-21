using Lab4._3;
using System.Drawing;
using Rectangle = Lab4._3.Rectangle;


Circle circle = new Circle();
Rectangle rectangle = new Rectangle();
rectangle.InputData();
Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rectangle.Area());
Console.WriteLine("Chu vi hinh chu nhat la: {0:N}", rectangle.Circumference());
circle.InputData();
Console.WriteLine("Dien tich hinh tron la: {0:N}", circle.Area());
Console.WriteLine("Chi vi hinh tron la: {0:N}", circle.Circumference());
