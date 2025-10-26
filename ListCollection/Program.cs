// https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection
// Learn to manage data colections using List<T> in C#

// A basic list example
List<string> names = ["Steve", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Console.Write seperator
Console.Write("\n");

// Modify list contents
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Console.Write seperator
Console.Write("\n");

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
Console.WriteLine($"The list has {names.Count} people in it.");

// Search and sort lists

// Console.Write seperator
Console.Write("\n");

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

// Sort the list, print new results

// Console.Write seperator
Console.Write("\n");

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// List of other types

// Console.Write seperator
Console.Write("\n");

List<int> fibonacciNumbers = [1, 1];
while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}