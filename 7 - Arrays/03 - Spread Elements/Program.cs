decimal[] q1Sales = [123.45m, 102.30m];
decimal[] q2Sales = [89.99m, 76.50m, 98.75m, 110.00m];
decimal[] q3Sales = [105.60m, 99.99m, 92.45m];
decimal[] q4Sales = [67.89m, 80.00m, 115.25m, 108.40m, 120.00m];
decimal[] allSales = CombineSalesAndBonuses(q1Sales, q2Sales, q3Sales, q4Sales);

Console.WriteLine(string.Join(",", allSales));

// Time and space O(n + m + k + l)
decimal[] CombineSalesAndBonuses(decimal[] q1Sales, decimal[] q2Sales, decimal[] q3Sales, decimal[] q4Sales)
    => [.. q1Sales, 1000m, .. q2Sales, 2500m, .. q3Sales, 4000m, .. q4Sales, 5500m];