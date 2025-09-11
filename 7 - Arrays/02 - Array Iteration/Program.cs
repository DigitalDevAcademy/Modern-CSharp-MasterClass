int[] numbers = [ 1, 2, 3, -4, 5 ]; // Sorted array in ascending order

SimpleIteration1(numbers);

SimpleIteration2(numbers);

int[] result = TwoSum(numbers, 8);
Console.WriteLine(string.Join(",", result));

// O(n) time, O(1) space
void SimpleIteration1(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write($"[{array[i]}]");
    }
    Console.WriteLine();
}

// O(n) time, O(1) space
void SimpleIteration2(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"[{item}]");
    }
    Console.WriteLine();
}

/* 
 * O(n) time only because the array is sorted otherwise it would need to be sorted which would increase time complexity
 * O(1) space
 */
int[] TwoSum(int[] array, int targetSum)
{
    int startIdx = 0;
    int endIdx = numbers.Length - 1;

    while (startIdx < endIdx)
    {
        int potentialMatch = array[startIdx] + array[endIdx];

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