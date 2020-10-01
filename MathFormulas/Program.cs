using System;

namespace MathFormulas
{
    class Program
    {
        public float BasicQuadratic(float x) // Problem a
        {
            return (x * x) + (2 * x) - 7;
        }

        public double NormalQuadratic(double a, double b, double c) // Problem b
        {
            double polynomial = Math.Sqrt( (b * b) - (4 * a * c) );
            if (polynomial < 0)
            {
                Console.WriteLine("This polynomial has no roots.");
                return polynomial;
            }
            else
            {
                return polynomial;
            }
        }

        public double LinearBlend(double s, double e, double t) // Problem c
        {
            return (s + t * (e - s));
        }

        public double TwoPoints(double x1, double y1, double x2, double y2) // Problem d
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public int InnerPoint(int Px, int Py, int Pz, int Qx, int Qy, int Qz) // Problem e
        {
            return (Px * Qx) + (Py * Qy) + (Pz * Qz);
        }

        public double PlanePoint(int Pa, int Pb, int Pc, int Pd, int x0, int y0, int z0) // Problem f
        {
            return ( (Pa * x0) + (Pb * y0) + (Pc * z0) + Pd) / Math.Sqrt(Math.Pow(Pa, 2) + Math.Pow(Pb, 2) + Math.Pow(Pc, 2) );
        }

        public double CubicBezier(float t, float P0, float P1, float P2, float P3) // Problem g
        {
            return (Math.Pow(1 - t, 3) * P0) + (3 * Math.Pow(1 - t, 2) * t * P1) + (3 * (1 - t) * Math.Pow(t, 2) * P2) + (Math.Pow(t, 3)*P3);
        }

        static void Main()
        {

        }
    }
}
