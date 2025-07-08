int[] numbers = [10, 10, 2, 2, 30, 30, 4, 4, 50, 50];

// O(n) time, O(1) space
var indexNotFound = Array.IndexOf(numbers, 100);
Console.WriteLine($"Found Index: {indexNotFound}");

var indexFound = Array.IndexOf(numbers, 50);
Console.WriteLine($"Found Index: {indexFound}");

// O(n) time, O(1) space
var lastIndexFound = Array.LastIndexOf(numbers, 50);
Console.WriteLine($"Found Index: {lastIndexFound}");

// Time and space both .NET runtime dependent
Array.Sort(numbers);
var sortedAsc = string.Join(", ", numbers);
Console.WriteLine(sortedAsc);

// O(n) time, O(1) space
Array.Reverse(numbers);
var reveresed = string.Join(", ", numbers);
Console.WriteLine(reveresed);

// O(n) time, O(1) space
Array.Fill(numbers, 0);
var refilled = string.Join(", ", numbers);
Console.WriteLine(refilled);