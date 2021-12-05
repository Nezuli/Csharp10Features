using CSharp10Features.StructureTypesImprovements;

var rectangle = new Rectangle(100, 200);
var newOne = rectangle with { Width = 300 };

Console.WriteLine($"1 - {rectangle}");
Console.WriteLine($"2 - {newOne}");
