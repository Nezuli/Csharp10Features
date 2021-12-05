using CSharp10Features.RecordStruct;

var rectangle = new Rectangle(100, 200);
var rectangle2 = new Rectangle(100, 200);
var rectangle3 = rectangle;


Console.WriteLine($"1 - {rectangle}");
Console.WriteLine($"2 - {rectangle2}");
Console.WriteLine($"3 - {rectangle3}");

Console.WriteLine($"Rectangle 1 and 2 are equal: {rectangle == rectangle2}");
Console.WriteLine($"Rectangle 1 and 3 are equal: {rectangle == rectangle3}");
Console.WriteLine($"Rectangle 2 and 3 are equal: {rectangle2 == rectangle3}");
