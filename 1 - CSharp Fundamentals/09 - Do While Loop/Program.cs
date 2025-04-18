var input = string.Empty;

/*
 We only ask for user input once at the beginning
 After that, the do-while loop will run an unknown number of times — 
 everything depends on the user's input
*/

do
{
    input = Console.ReadLine();
    Console.WriteLine(input);

} while (!string.IsNullOrEmpty(input));