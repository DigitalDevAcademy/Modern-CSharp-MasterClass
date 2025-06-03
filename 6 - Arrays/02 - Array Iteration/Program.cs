int[] numbers = { 1, 1, 1, 2, 2 };

/* 
 * Recommended for iterating arrays
 * For loops are used to repeat actions a set number of times which fits well with arrays having a fixed size 
 */ 
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);
}
Console.WriteLine();

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i]);
}
Console.WriteLine();

// While/Do...While loops are used to repeat actions an unknown number of times which does not fit well with arrays having a fixed size
var j = 0;
while (j < numbers.Length)
{
    Console.Write(numbers[j]);
    j++;
}
Console.WriteLine();

j = numbers.Length - 1;
while (j >= 0)
{
    Console.Write(numbers[j]);
    j--;
}