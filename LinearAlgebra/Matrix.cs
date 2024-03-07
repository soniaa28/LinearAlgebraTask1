using System;
using System.Text;

namespace LinearAlgebraTask1
{
    public class Matrix
    {        public int N { get; set; }

        public int M { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public double MatrixNorma { get; private set; }
        public int MatrixMaxModul { get; private set; }
        public int[,] Matrix_;

        public Matrix()
        {
            N = 1;
            M = 1;
            Min = 0;
            Max = 0;
            Matrix_ = new int[N, M];
        }

        public Matrix(int n, int m)
        {
            N = n;
            M = m;
            Min = 0;
            Max = 0;
            Matrix_ = new int[N, M];
        }

        public Matrix(int n, int m, int min, int max)
        {
            N = n;
            M = m;
            Min = min;
            Max = max;
            Matrix_ = new int[N, M];

            matrixCreate(Min, Max);
            CalculateMatrixNorma();
            MatrixMaxModul = matrixMaxModude();
        }

        public string ShowMatrix()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < M; ++j)
                {
                    sb.Append($"{Matrix_[i, j]} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    output += Matrix_[i, j] + " ";
                }
                output += "\n";
            }
            return output;
        }
        // Create random matrix
        public void matrixCreate(int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Matrix_[i, j] = rnd.Next(min, max);
                }
            }
        }

        // Finds maximum of matrix squared elements
        public int matrixMaxModude()
        {
            Matrix matrixSquare = new Matrix(N, M);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrixSquare.Matrix_[i, j] += Matrix_[i, j] * Matrix_[i, j];
                }
            }
            int max = matrixSquare.Matrix_[0, 0];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matrixSquare.Matrix_[i, j] > max)
                    {
                        max = matrixSquare.Matrix_[i, j];
                    }
                }
            }

            return max;
        }

        // Function to calculate matrix norm
        public void CalculateMatrixNorma()
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sum += Matrix_[i, j] * Matrix_[i, j];
                }
            }
            MatrixNorma = Math.Sqrt(sum);
        }
        public static Vector operator *(Matrix matrix, Vector vector)
        {
            if (matrix.N != vector.Dimension)
                throw new ArgumentException("Matrix column count must match vector dimension.");

            int[] resultComponents = new int[matrix.M];
            for (int i = 0; i < matrix.M; i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.N; j++)
                {
                    sum += matrix.Matrix_[i, j] * vector.Components[j];
                }
                resultComponents[i] = sum;
            }

            return new Vector(resultComponents);
        }
        public static Matrix operator +(Matrix LeftMatrix, Matrix RightMatrix)
        {
            if (LeftMatrix.N == RightMatrix.N && LeftMatrix.M == RightMatrix.M)
            {
                Matrix result = new Matrix(LeftMatrix.N, LeftMatrix.M);

                for (int i = 0; i < LeftMatrix.N; i++)
                {
                    for (int j = 0; j < LeftMatrix.M; j++)
                    {
                        result.Matrix_[i, j] = LeftMatrix.Matrix_[i, j] + RightMatrix.Matrix_[i, j];
                    }
                }
                result.CalculateMatrixNorma();
                result.MatrixMaxModul = result.matrixMaxModude();

                return result;
            }
            else
                return LeftMatrix;
        }

        public static Matrix operator -(Matrix LeftMatrix, Matrix RightMatrix)
        {
            if (LeftMatrix.N == RightMatrix.N && LeftMatrix.M == RightMatrix.M)
            {
                Matrix result = new Matrix(LeftMatrix.N, LeftMatrix.M);

                for (int i = 0; i < LeftMatrix.N; i++)
                {
                    for (int j = 0; j < LeftMatrix.M; j++)
                    {
                        result.Matrix_[i, j] = LeftMatrix.Matrix_[i, j] - RightMatrix.Matrix_[i, j];
                    }
                }
                result.CalculateMatrixNorma();
                result.MatrixMaxModul = result.matrixMaxModude();

                return result;
            }
            else
                return LeftMatrix;
        }

        public static Matrix operator *(Matrix LeftMatrix, Matrix RightMatrix)
        {
            if (LeftMatrix.M == RightMatrix.N)
            {
                Matrix result = new Matrix(LeftMatrix.N, RightMatrix.M);

                for (int i = 0; i < LeftMatrix.N; i++)
                {
                    for (int j = 0; j < RightMatrix.M; j++)
                    {
                        for (int k = 0; k < LeftMatrix.M; k++)
                        {
                            result.Matrix_[i, j] += LeftMatrix.Matrix_[i, k] * RightMatrix.Matrix_[k, j];
                        }
                    }
                }
                result.CalculateMatrixNorma();
                result.MatrixMaxModul = result.matrixMaxModude();

                return result;
            }
            else
                return LeftMatrix;
        }
    }
}
