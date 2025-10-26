// https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops
// Branches and Loops

// C# if statements and loops - conditional logic

int a = 5;
int b = 6;
if (a + b > 10) Console.WriteLine("The answer is greater than 10.\n");
// Make if and else work together
else Console.WriteLine("The answer is less than 10.\n");

int c = 5;
int d = 5;
int e = 4;
if ((c + d + e > 10) && (c == d))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second.\n");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second.\n");
}

// Use loops to repeat operations

int counter = 0;
Console.WriteLine("While loop: ");
while (counter <= 10)
{
    Console.WriteLine($"Hell World! The counter is {counter}.");
    counter++;
}

// Seperate console print, reset counter
Console.WriteLine("\n");
counter = 0;

// Run a do {...} while (...) loop
Console.WriteLine("Do {...} while (...) loop: ");
do
{
    Console.WriteLine($"Hello World! The counter is {counter}.");
    counter++;
} while (counter <= 10);

// Seperate console print
Console.WriteLine("\n");

// Work with the for loop

Console.WriteLine("For loop: ");
for (counter = 0; counter <= 10; counter++)
{
    Console.WriteLine($"Hello World! The counter is {counter}.");
}

// Create nested loops

// Seperate the console print
Console.WriteLine("\n");

Console.WriteLine("Nested for loops, nested loop using char initializer: ");
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column <= 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column}).");
    }
}

// Seperate the console print
Console.WriteLine("\n");

Console.WriteLine("For loop updating outside variable with a conditional in the code block:");
int sum = 0;
for (int number = 1; number < 21; number++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"The sum is {sum}.");