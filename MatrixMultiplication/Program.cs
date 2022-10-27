using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] b = new int[,] { { 5, 6 }, { 7, 8 }, { 9, 10 } };
            //  46  52
            // 109 124 
            int[,] c = FalkScheme(a, b);
        }

        public static int[,] FalkScheme(int[,] Matrix1, int[,] Matrix2)
        {
            if (Object.ReferenceEquals(null, Matrix1))
                throw new ArgumentNullException("Matrix1");
            else if (Object.ReferenceEquals(null, Matrix2))
                throw new ArgumentNullException("Matrix2");

            int r1 = Matrix1.GetLength(0);
            int c1 = Matrix1.GetLength(1);

            int r2 = Matrix2.GetLength(0);
            int c2 = Matrix2.GetLength(1);

            if (c1 != r2)
                throw new ArgumentOutOfRangeException("Matrix2", "Matrixes dimensions don't fit.");

            int[,] result = new int[r1, c2];

            // Naive matrix multiplication: O(n**3) 
            // Use Strassen algorithm O(n**2.81) in case of big matrices
            for (int r = 0; r < r1; ++r)
                for (int c = 0; c < c2; ++c)
                {
                    int s = 0;

                    for (int z = 0; z < c1; ++z)
                        s += Matrix1[r, z] * Matrix2[z, c];

                    result[r, c] = s;
                }

            return result;
        }
    }
}
