int[] numbers = [ 1, 2, 3, -4, 5 ]; // Sorted array in ascending order

/* 
 * O(n) time, O(1) space
 * Since we have access to the index we can manipulate it and iterate backwards
 */
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"[{numbers[i]}]");
}
Console.WriteLine();

/* 
 * O(n) time, O(1) space
 * We do not have access to the index, all we can do is iterate the array normally via cleaner syntax
 */
foreach (int number in numbers)
{
    Console.Write($"[{number}]");
}
Console.WriteLine();

/* 
 * O(n) time only because the array is sorted otherwise it would need to be sorted which would increase time complexity
 * O(1) space
 */
var result = TwoSum(numbers, 8);
Console.WriteLine(string.Join(",", result));

int[] TwoSum(int[] array, int targetSum)
{
    var startIdx = 0;
    var endIdx = numbers.Length - 1;

    while (startIdx < endIdx)
    {
        var potentialMatch = array[startIdx] + array[endIdx];

        if (potentialMatch == targetSum)
        {
            return [ array[startIdx], array[endIdx] ];
        }
        else if (potentialMatch < targetSum)
        {
            startIdx++;
        }
        else
        {
            endIdx--;
        }
    }

    return [];
}
