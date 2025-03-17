// These are only some of the examples
// Full list of operator precedence can be found at https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170

// Declaring a result variable to reuse in all examples
int result;

// Multiplication (*) has higher precedence than addition (+), so it executes first
result = 10 + 5 * 2;
Console.WriteLine(result); // Output: 20

// Changing the order with parentheses
result = (10 + 5) * 2;
Console.WriteLine(result); // Output: 30

// Subtraction (-) has left-to-right associativity, so we evaluate from left to right
result = 20 - 10 - 5;
Console.WriteLine(result); // Output: 5

// Changing the order with parentheses
result = 20 - (10 - 5);
Console.WriteLine(result); // Output: 15

// Both division (/) and multiplication (*) have the same precedence, but follow left-to-right associativity
result = 100 / 10 * 5; 
Console.WriteLine(result); // Output: 50

// Changing the order with parentheses
result = 100 / (10 * 5);
Console.WriteLine(result); // Output: 2