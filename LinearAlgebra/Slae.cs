namespace LinearAlgebraTask1
{
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
