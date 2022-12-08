namespace MindBoxLib
{
    public class Circle
    {
        public double Radius { get; private set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }

    public class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double A, double B, double C)
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentException($"Ошибка: Длина стороны не может быть меньше 0.");
            else if (A > (B + C) || B > (A + C) || C > (A + B))
                throw new ArgumentException($"Ошибка: Треугольник с такими сторонами не может существовать.");
            else
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }
        }

        public double CalcSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1);
        }

        public bool IsRectangular()
        {
            bool check = 
                (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) 
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
            return check;
        }
    }
}