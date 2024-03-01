using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LinearAlgebraTask1
{
    public partial class Form1 : Form
    {
        Matrix a;
        Matrix b;
        Matrix c;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMatrix1_Click(object sender, EventArgs e)
        {
            a = new Matrix((int)NumN.Value, (int)NumM.Value, (int)NumMin.Value, (int)NumMax.Value + 1);
            textBox1.Clear();
            textBox1.Text = a.ShowMatrix();

            a.CalculateMatrixNorma(); // обчислення евклідової норми
            labelNormA.Text = $"Norma: {Convert.ToString(a.MatrixNorma)}";
            labelModuleA.Text = $"Max module: {Convert.ToString(a.MatrixMaxModul)}";
        }

        private void CreateMatrix2_Click(object sender, EventArgs e)
        {
            b = new Matrix((int)NumN.Value, (int)NumM.Value, (int)NumMin.Value, (int)NumMax.Value + 1);
            textBox2.Clear();
            textBox2.Text = b.ShowMatrix();

            b.CalculateMatrixNorma(); // обчислення евклідової норми
            labelNormB.Text = $"Norma: {Convert.ToString(b.MatrixNorma)}";
            labelModuleB.Text = $"Max module: {Convert.ToString(b.MatrixMaxModul)}";
        }

        private void ReadMatrix1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            var fileName = textBox4.Text;
            var readRes = new List<int>();
            int lines = 0;

            foreach (string line in File.ReadLines(fileName))
            {
                var splitedLine = line.Split(' ');
                lines++;

                for (int i = 0; i < splitedLine.Length; i++)
                {
                    int num;
                    if (int.TryParse(splitedLine[i], out num))
                    {
                        readRes.Add(num);
                    }
                    else
                    {
                        // Обробка помилки: наприклад, можна проігнорувати неправильні значення або вивести повідомлення про помилку
                        Console.WriteLine("Неправильний формат числа: " + splitedLine[i]);
                    }
                }
            }
            a = new Matrix(lines, readRes.Count / lines);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < readRes.Count / lines; j++)
                {
                    a.Matrix_[i, j] = readRes[i * (readRes.Count / lines) + j]; // Оновлено формулу для індексації
                }
            }

            textBox1.Text = a.ShowMatrix();
            a.CalculateMatrixNorma(); // обчислення евклідової норми

            labelNormA.Text = $"Norma: {Convert.ToString(a.MatrixNorma)}";
            labelModuleA.Text = $"Max module: {Convert.ToString(a.MatrixMaxModul)}";
        }

        private void ReadMatrix2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var fileName = textBox4.Text;
            var readRes = new List<int>();
            int lines = 0;

            foreach (string line in File.ReadLines(fileName))
            {
                var splitedLine = line.Split(' ');
                lines++;

                for (int i = 0; i < splitedLine.Length; i++)
                {
                    int num;
                    if (int.TryParse(splitedLine[i], out num))
                    {
                        readRes.Add(num);
                    }
                    else
                    {
                        // Обробка помилки: наприклад, можна проігнорувати неправильні значення або вивести повідомлення про помилку
                        Console.WriteLine("Неправильний формат числа: " + splitedLine[i]);
                    }
                }
            }
            b = new Matrix(lines, readRes.Count / lines);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < readRes.Count / lines; j++)
                {
                    b.Matrix_[i, j] = readRes[i * (readRes.Count / lines) + j]; // Оновлено формулу для індексації
                }
            }
            textBox2.Text = b.ShowMatrix();
            b.CalculateMatrixNorma(); // обчислення евклідової норми

            labelNormB.Text = $"Norma: {Convert.ToString(b.MatrixNorma)}";
            labelModuleB.Text = $"Max module: {Convert.ToString(b.MatrixMaxModul)}";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            c = a + b;
            textBox3.Clear();
            textBox3.Text = c.ShowMatrix();

            c.CalculateMatrixNorma(); // обчислення евклідової норми
            labelNormC.Text = $"Norma: {Convert.ToString(c.MatrixNorma)}";
            labelModuleC.Text = $"Max module: {Convert.ToString(c.MatrixMaxModul)}";
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            c = a - b;
            textBox3.Clear();
            textBox3.Text = c.ShowMatrix();

            c.CalculateMatrixNorma(); // обчислення евклідової норми
            labelNormC.Text = $"Norma: {Convert.ToString(c.MatrixNorma)}";
            labelModuleC.Text = $"Max module: {Convert.ToString(c.MatrixMaxModul)}";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            c = a * b;
            textBox3.Clear();
            textBox3.Text = c.ShowMatrix();

            c.CalculateMatrixNorma(); // обчислення евклідової норми
            labelNormC.Text = $"Norma: {Convert.ToString(c.MatrixNorma)}";
            labelModuleC.Text = $"Max module: {Convert.ToString(c.MatrixMaxModul)}";
        }

        // Files: [Project name]/bin/Debug/[name].txt
        private async void WriteButton_Click(object sender, EventArgs e)
        {
            string path = @"Result.txt";

            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox3.Text);
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }

    public class Matrix
    {
        public int N { get; set; }
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

        // Функція для обчислення евклідової норми матриці
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


// System of linear algebraic equations
public class Slae
    {
        public Matrix A { get; set; } 

        public Matrix X { get; set; } 

        public Matrix B { get; set; }

        public Slae()
        {
            A = new Matrix();
            X = new Matrix();
            B = new Matrix();
        }

        public Slae(Matrix a, Matrix x, Matrix b)
        {
            A = a;
            X = x;
            B = b;
        }
    }
}