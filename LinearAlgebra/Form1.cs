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
        private Vector vector1;
        private Vector vector2;
        private Vector sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }

        private Vector ParseVector(string input)
        {
            string[] components = input.Split(',');
            int[] parsedComponents = new int[components.Length];

            for (int i = 0; i < components.Length; i++)
            {
                parsedComponents[i] = int.Parse(components[i].Trim());
            }

            return new Vector(parsedComponents);
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

   

}