// These are only some of the examples
// Full list of operator precedence can be found at https://learn.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-170

// Declaring a result variable to reuse in all examples
int result;

// Multiplication (*) has higher precedence than addition (+) - it executes first
result = 5 + 2 * 4;
Console.WriteLine(result); // Output: 13

// Order changed with parentheses
result = (5 + 2) * 4;
Console.WriteLine(result); // Output: 28

// Subtraction (-) has left-to-right associativity - we evaluate from left to right
result = 10 - 5 - 2;
Console.WriteLine(result); // Output: 3

// Order changed with parentheses
result = 10 - (5 - 2);
Console.WriteLine(result); // Output: 7

// Both division (/) and multiplication (*) have the same precedence - follow left-to-right associativity
result = 50 / 5 * 2; 
Console.WriteLine(result); // Output: 20

// Order changed with parentheses
result = 50 / (5 * 2);
Console.WriteLine(result); // Output: 5