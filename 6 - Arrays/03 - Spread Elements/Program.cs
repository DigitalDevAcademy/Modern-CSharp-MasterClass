int[] q1Sales = [150, 200, 359];
int[] q2Sales = [420, 120, 400, 550, 700];
int[] q3Sales = [550, 700, 800, 1000];
int[] q4Sales = [1200, 5000, 6500, 8100, 10525];
int[] allSales = CombineSalesAndBonuses(q1Sales, q2Sales, q3Sales, q4Sales);

Console.WriteLine(string.Join(",", allSales));

// Time and space O(n + m + k + l)
int[] CombineSalesAndBonuses(int[] q1Sales, int[] q2Sales, int[] q3Sales, int[] q4Sales)
    => [.. q1Sales, 1000, .. q2Sales, 2500, .. q3Sales, 4000, .. q4Sales, 5500];