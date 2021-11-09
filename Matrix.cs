using System;
using System.Collections.Generic;

namespace ConsoleLabsOOP
{
    class Matrix
    {
        Random rand = new Random();

        List<List<int>> matrix = new List<List<int>>();

        public Matrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < n; j++)
                    matrix[i].Add(rand.Next(-100, 100));
            }
        }

        public void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i][j] + "\t");
                Console.Write("\n");
            }
        }

        public void Change(int n)
        {
            int t;
            for (int i = 0; i < n; i++)
            {
                t = matrix[i][i];
                matrix[i][i] = matrix[i][n - i - 1];
                matrix[i][n - i - 1] = t;
            }
        }
    }
}
