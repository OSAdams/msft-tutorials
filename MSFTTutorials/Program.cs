// See https://aka.ms/new-console-template for more information
// var VariableName = "Hello World!";
// Console.WriteLine(VariableName);
// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.WriteLine("You wrote your first lines of code.");
// Console.WriteLine("Congratulations!");
// Console.WriteLine("You wrote your first lines of code.");
// Console.WriteLine("This is the first line.");
// Console.WriteLine(VariableName);
// Console.WriteLine("This is the second line.");
// Console.WriteLine("==============================");
// Console.Write('Single Quotes.');

// Console.WriteLine(123);
// Console.WriteLine(0.25F);
// Console.WriteLine(2.625);
// Console.WriteLine(12.39816m);
// Console.WriteLine(true);
// Console.WriteLine(false);
// Console.WriteLine("=============================");

// string firstName;
// firstName = "Bob";
// string lastName = "Saget";
// Console.Write("Your first name is ");
// Console.Write(firstName);
// Console.Write("! Your last name is ");
// Console.Write(lastName);
// Console.WriteLine("!");

// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName);

// string errorTime;
// Console.WriteLine(errorTime);

//string firstName = "Bob";
//int messages = 3;
//decimal temperature = 34.4m;

//Console.Write("Hello, ");
//Console.Write(firstName);
//Console.Write("! You have ");
//Console.Write(messages);
//Console.Write(" messages in your inbox. The temperature is ");
//Console.Write(temperature);
//Console.WriteLine(" celcius.");
//Console.Write(34.40m);

//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");

// ===================================================
// Format output using character escape sequences
// ===================================================

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");

// ===================================================
// Verbatim string literal
// ===================================================

//Console.WriteLine(@"    c:\source\repos    
//        (this is where your code goes)");

// ===================================================
// Unicode Escape Characters
// ===================================================

// Kon'nichiwa World
//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// ===================================================
// Format output using unicode escape characters
// ===================================================

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");
//Console.WriteLine("\n=============================\n");

// ===================================================
// Concatenate a literal string and a variable
// ===================================================

//string firstName = "Bob";
//string message = "Hello " + firstName;
//Console.WriteLine(message);

// ===================================================
// Concatenate multiple variables and literal strings
// ===================================================

//string firstName = "Bob";
//string greeting = "Hello";
//string message = greeting + " " + firstName + "!";
//Console.WriteLine(message);
//Console.WriteLine(greeting + " " + firstName + "!");

// ===================================================
// Use string interpolation to combine a literal string and a variable value
// ===================================================

//string message = $"{greeting} {firstName}!";
//Console.WriteLine(message);

//int version = 11;
//string updateText = "Update to Windows";
//string message = $"Do not {updateText} {version}";
//Console.WriteLine(message);

// ===================================================
// Combine verbatim literals and string interpolation
// ===================================================

//string projectName = "First-Project";
//Console.WriteLine($@"C:\Output\{projectName}\Data");

// ===================================================
// Challenge
// ===================================================

//string projectName = "ACME";

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";

//string russianDirectory = $@"c:\Exercise\{projectName}\ru-RU\data.txt";

//string englishMessage = "View English output:";

//string englishDirectory = $@"c:\Exercise\{projectName}\data.txt";

//string fullEnglishMessage = $"{englishMessage}\n\t{englishDirectory}\n";

//string fullRussianMessage = $"{russianMessage}\n\t{russianDirectory}\n";

//Console.WriteLine(fullEnglishMessage);
//Console.WriteLine(fullRussianMessage);

// Tutorial Solution

//string projectName = "ACME";
//string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
//Console.WriteLine($"View English output:\n\t{englishLocation}\n");

//string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
//string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
//Console.WriteLine($"{russianMessage}:\n\t{russianLocation}\n");

// Testing for an error (lol tutorial with AI QUESTIONS, THE QUESTIONS ARE SHIT JUST SO YOU KNOW)
//Console.WriteLine("C:\new\folder");
//Console.WriteLine("String " + "concatenation!");

// ===================================================
// Add two numeric values
// ===================================================

//int firstNumber = 12;
//int secondNumber = 7;
//Console.WriteLine(firstNumber + secondNumber);

// ===================================================
// Mix data types to force implicit type conversions
// ===================================================

//string firstName = "Bob";
//int widgetsSold = 7;
//Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// ===================================================
// Attempt a more advanced case of adding numbers and concatenating strings
// ===================================================

//Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

// ===================================================
// Add parentheses to clarify your intention to the compiler
// ===================================================

//Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// ===================================================
// Write code to perform addition, subtraction, multiplication, and division with integers
// ===================================================

//int sum = 7 + 5;
//int difference = 7 - 5;
//int product = 7 * 5;
//int quotient = 7 / 5;

//Console.WriteLine("Sum: " + sum);
//Console.WriteLine("Difference: " + difference);
//Console.WriteLine("Product: " + product);
//Console.WriteLine("Quotient: " + quotient);

// ===================================================
// Add code to perform division using literal decimal data
// ===================================================

//decimal decimalQuotient = 7 / 5.0m;
//decimal decimalQuotient = 7.0m / 5.0m;
//decimal decimalQuotient = 7.0m / 5;
//Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// ===================================================
// Add code to cast results of integer division
// ===================================================

//int first = 7;
//int second = 5;
//decimal quotient = (decimal)first / (decimal)second;
//Console.WriteLine(quotient);

// ===================================================
// Write code to determine the remainder after integer division
// ===================================================

//Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
//Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// ===================================================
// Write code to exercise C#'s order of operations
// ===================================================

//int value1 = 3 + 4 * 5;
//int value2 = (3 + 4) * 5;
//Console.WriteLine(value1);
//Console.WriteLine(value2);

// ===================================================
// Write code to increment and decrement a value
// ===================================================

//int value = 1;
//value = value + 1;
//Console.WriteLine("First increment: " + value);
//value += 1;
//Console.WriteLine("Second increment: " + value);
//value++;
//Console.WriteLine("Third increment: " + value);
//value = value - 1;
//Console.WriteLine("First decrement: " + value);
//value -= 1;
//Console.WriteLine("Second decrement: " + value);
//value--;
//Console.WriteLine("Third decrement: " + value);

// ===================================================
// Write code to increment and decrement a value
// ===================================================

int value = 1;
value++;
Console.WriteLine("First: " + value);
// There's two steps to this line:
// Retrieve the current value of the variable value and use that in the string interpolation operation.
// Increment the value.
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
// Here, the order of operations is switched because the ++ operator is placed before the operand value.
// Increment the value.
// Retrieve the new incremented value of the variable value and use that in the string operation.
Console.WriteLine("Fourth: " + (++value));

// ===================================================
// Challenge: Calculate Celsius given the current temperature in Fahrenheit
// ===================================================

int fahrenheit = 94;
Console.WriteLine("The temperature is " + ((fahrenheit - 32) * (5 / 9.0m)) + " celcius.");

// Method definition to convert fahrenheit to celcius.
void FahrenheitToCelcius(int fahrenheit)
{
    decimal celcius = (fahrenheit - 32) * (5 / 9.0m);
    Console.WriteLine($"The temperature is {celcius} celcius.");
    return;
}

// FahrenheitToCelcius method being called with one argument, the value of the variable fahrenheit
FahrenheitToCelcius(fahrenheit);

// Tutorial solution
//int fahrenheit = 94;
//decimal celsius = (fahrenheit - 32m) * (5m / 9m);
//Console.WriteLine("The temperature is " + celsius + " Celsius.");

Console.WriteLine("Windows " + 1 + 1);
Console.WriteLine(3 + 1 * 5 / 2);
Console.WriteLine(5 / 10);