using System.Text.Json;

var names = new[] { "Ole", "Dole", "Doffen" };
var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);
