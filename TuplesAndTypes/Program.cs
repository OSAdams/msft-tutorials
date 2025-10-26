// https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/ 

// Tuples

// Tuples are an ordered sequence of values with a fixed length. 
// Each element of a tuples has a type and an optional name.

var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.\n");

// You can reassign any member of a tuple.

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.\n");

// You can also create a new tuple that's a modified copy of the original using a with expression.

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.\n");

// Tuples are structural types. In other words, tuple types don't have names like string or int.
// A tuple type is defined by the number of members, referred to as arity, and the types of those members.
// The member names are for convenience.
// You can assign a tuple to a tuple with the same arity and types even if the members have different names.

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine($"The value of subscript is {subscript}.\n");

// Create record types

// Tuples are great fo those times when you want multiple values in teh same structure.
// They're lightweight, and can be declared as they're used.
// As your program goes, you might find that you use the same tuple type throughout your code. 
// If your app does work in the 2D graph space, the tuples that represent points might be common.
// Once you find that, you can declare a record type that stores those values and provides more capabilities.

class TupleUpdate
{
    public record Point(int X, int Y)
    {
        public double Slope() => (double)Y / (double)X;
    }

    public static void Main()
    {
        Point pt = new Point(1, 1);
        var pt2 = pt with { Y = 10 };
        double slope = pt.Slope();
        Console.WriteLine($"The two points are {pt} and {pt2}");
        Console.WriteLine($"The slope of {pt} is {slope}");
    }
}