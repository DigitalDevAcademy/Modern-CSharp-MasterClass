int[][] allClassGrades = [
    [60, 70, 80, 90, 30],
    [70, 75, 80, 76, 78, 81],
    [65, 89, 80],
    [57, 60, 85, 90]
];

DisplayClassGrades(allClassGrades);

// O(n * m) time, O(1) space
void DisplayClassGrades(int[][] classGrades)
{
    for (int classIdx = 0; classIdx < classGrades.Length; classIdx++)
    {
        Console.WriteLine($"Class {classIdx + 1}");
        foreach (int studentGrade in classGrades[classIdx])
        {
            Console.Write($"[{studentGrade}]");
        }
        Console.WriteLine();
    }
}
