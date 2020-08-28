using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algorithms.Searching;
using System;
using Algorithms.Arrays.Matrix;

namespace Algorithms.Test
{
    [TestClass]
    public class Matrix
    {
        [TestMethod]
        public void RotateImageMatrix()
        {
            int[][] matrix = new int[][]
            { new int[] { 1, 2, 3 },
            new int[] { 4,5,6 },
            new int[] { 7,8,9 }};

            RotateImage.Rotate(matrix);
            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
