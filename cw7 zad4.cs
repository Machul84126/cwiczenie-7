using System;

public class ClosestRowsFinder
{
    public static void FindClosestRows(int[][] array)
    {
        int numRows = array.Length;
        int row1 = 0;
        int row2 = 0;
        int minDiff = int.MaxValue;

        for (int i = 0; i < numRows - 1; i++)
        {
            for (int j = i + 1; j < numRows; j++)
            {
                int diff = CalculateRowDifference(array[i], array[j]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    row1 = i;
                    row2 = j;
                }
            }
        }

        Console.WriteLine($"Najbliższe wiersze: {row1}, {row2}");
    }

    private static int CalculateRowDifference(int[] row1, int[] row2)
    {
        int difference = 0;
        int numCols = Math.Min(row1.Length, row2.Length);

        for (int k = 0; k < numCols; k++)
        {
            int value1 = row1[k];
            int value2 = row2[k];
            difference += (value1 - value2) * (value1 - value2);
        }

        return difference;
    }

    public static void Main(string[] args)
    {
        int[][] array = {
            new int[] { 1, 2, 3 },
            new int[] { 4, 2, 5 },
            new int[] { 2, 3, 6 },
            new int[] { 3, 1, 4 }
        };

        FindClosestRows(array);
    }
}