using System;

public class Vector
{
    public int Dimension { get; }
    public int[] Components { get; }

    public Vector(int dimension)
    {
        if (dimension <= 0)
            throw new ArgumentException("Dimension must be a positive integer.");

        Dimension = dimension;
        Components = new int[dimension];
    }
    public override string ToString()
    {
        return string.Join(", ", Components);
    }
    public Vector(params int[] components)
    {
        if (components == null)
            throw new ArgumentNullException(nameof(components));

        Dimension = components.Length;
        Components = components;
    }

    public double CalculateVectorNorm()
    {
        double sumOfSquares = 0;
        foreach (int component in Components)
        {
            sumOfSquares += Math.Pow(component, 2);
        }
        return Math.Sqrt(sumOfSquares);
    }

    public int CalculateVectorMaxModul()
    {
        int maxModul = Math.Abs(Components[0]);
        foreach (int component in Components)
        {
            int modul = Math.Abs(component);
            if (modul > maxModul)
            {
                maxModul = modul;
            }
        }
        return maxModul;
    }

    public static Vector operator +(Vector left, Vector right)
    {
        if (left.Dimension != right.Dimension)
            throw new ArgumentException("Vectors must have the same dimension for addition.");

        int[] resultComponents = new int[left.Dimension];
        for (int i = 0; i < left.Dimension; i++)
        {
            resultComponents[i] = left.Components[i] + right.Components[i];
        }

        return new Vector(resultComponents);
    }

    public static Vector operator -(Vector left, Vector right)
    {
        if (left.Dimension != right.Dimension)
            throw new ArgumentException("Vectors must have the same dimension for subtraction.");

        int[] resultComponents = new int[left.Dimension];
        for (int i = 0; i < left.Dimension; i++)
        {
            resultComponents[i] = left.Components[i] - right.Components[i];
        }

        return new Vector(resultComponents);
    }

    public static int operator *(Vector left, Vector right)
    {
        if (left.Dimension != right.Dimension)
            throw new ArgumentException("Vectors must have the same dimension for dot product.");

        int dotProduct = 0;
        for (int i = 0; i < left.Dimension; i++)
        {
            dotProduct += left.Components[i] * right.Components[i];
        }

        return dotProduct;
    }
}
