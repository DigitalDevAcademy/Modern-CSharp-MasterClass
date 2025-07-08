// Declaring a variable representing a test score - image we have many of them from all students
int testScore = 100;

// We then could retrieve those scores and perform a conditional check to see if the students passed or failed
string result = testScore >= 80 ? "Pass" : "Fail";

// Notice how the result is of type string because Operand 2 and Operand 3 are of type string
Console.WriteLine(result);

// Now let's declare another variable representing an item quantity
int itemQuantity = 5;

// We can check and see if there are 5 or more items then provide a 25% discount, otherwise provide a 5% discount
decimal discount = itemQuantity >= 5 ? 0.25m : 0.05m;

// Once again notice how discount is of type decimal becasue both Operand 2 and 3 are of type decimal
Console.WriteLine(discount);