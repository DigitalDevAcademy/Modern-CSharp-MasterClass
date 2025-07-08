int[][] allClassGrades = [
    [60, 70, 80, 90, 30],
    [70, 75, 80, 76, 78, 81],
    [65, 89, 80],
    [57, 60, 85, 90]
];

DisplayClassGrades(allClassGrades);

/* 
 * O(n * m) time, O(1) space
 * n is the number of arrays within the jagged array and m is the length of each array
 * As mentioned we estimate the worse case where all array lengths are equal
 */
void DisplayClassGrades(int[][] classGrades)
{
    for (int classIdx = 0; classIdx < classGrades.Length; classIdx++)
    {
        Console.WriteLine($"Class {classIdx + 1}");
        foreach (var studentGrade in classGrades[classIdx])
        {
            Console.Write($"[{studentGrade}]");
        }
        Console.WriteLine();
    }
}
