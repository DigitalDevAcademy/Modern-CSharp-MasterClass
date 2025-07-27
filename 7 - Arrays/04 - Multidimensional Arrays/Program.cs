char[,] treasureMap = new char[7, 5]
{
    { '*', '*', ' ', 'X', 'X'},
    { '*', '*', ' ', ' ', ' '},
    { '*', '*', '*', '*', '*'},
    { '*', '*', 'X', '*', '*'},
    { '*', ' ', '*', '*', '*'},
    { ' ', ' ', ' ', ' ', ' '},
    { ' ', 'X', ' ', 'X', 'X'},
};

PrintTreasureLocations(treasureMap);

// O(n * m) time, O(1) space
void PrintTreasureLocations(char[,] map)
{
    var rows = map.GetLength(0);
    var cols = map.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (map[row, col] == 'X')
            {
                var isUpHidden = row > 0 && map[row - 1, col] == '*';
                var isDownHidden = row < rows - 1 && map[row + 1, col] == '*';
                var isLeftHidden = col > 0 && map[row, col - 1] == '*';
                var isRightHidden = col < cols - 1 && map[row, col + 1] == '*';

                var isHidden = isUpHidden && isDownHidden && isLeftHidden && isRightHidden;

                if (isHidden)
                {
                    Console.WriteLine($"Hidden treasure found at row {row} and col {col}!");
                }
                else
                {
                    Console.WriteLine($"Treasure found at row {row} and col {col}, but its not hidden!");
                }
            }
        }
    }
}