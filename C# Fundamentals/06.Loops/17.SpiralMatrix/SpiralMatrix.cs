using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int startRow = 0;
            int startCol = 0;
            int endRow = n - 1;
            int endCol = n - 1;
            string direction = "R";
            int a = 0;

            while (endCol >= startCol && endRow >= startRow)
            {
                if (direction == "R")
                {
                    for (int c = startCol; c <= endCol; c++)
                    {
                        matrix[startRow, c] = ++a;
                    }
                    startRow++;
                    direction = "D";
                }
                if (direction == "D")
                {
                    for (int r = startRow; r <= endRow; r++)
                    {
                        matrix[r, endCol] = ++a;
                    }
                    endCol--;
                    direction = "L";
                }
                if (direction == "L")
                {
                    for (int c = endCol; c >= startCol; c--)
                    {
                        matrix[endRow, c] = ++a;
                    }
                    endRow--;
                    direction = "U";
                }
                if (direction == "U")
                {
                    for (int r = endRow; r >= startRow; r--)
                    {
                        matrix[r, startCol] = ++a;
                    }
                    startCol++;
                    direction = "R";
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
