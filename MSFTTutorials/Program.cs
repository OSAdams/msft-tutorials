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

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string russianDirectory= $@"c:\Exercise\{projectName}\ru-RU\data.txt";

string englishMessage = "View English output:";

string englishDirectory = $@"c:\Exercise\{projectName}\data.txt";

string fullEnglishMessage = $"{englishMessage}\n\t{englishDirectory}";

string fullRussianMessage = $"{russianMessage}\n\t{englishDirectory}";



//Console.Write();
//Console.Write();
//Console.WriteLine();
//Console.WriteLine();

Console.WriteLine($"");