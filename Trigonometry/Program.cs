using System;

namespace Trigonometry
{
    class Program
    {

        // ----- NOTE -----
        // My algebra/trig teacher in high school was VERY particular about showing work and circling answers
        // As such, I may go into more detail than you feel is necessary for these problems
        // Additionally, the final answer of a mathmatical equation will be surrounded by *** asterisks *** to stand out, since I can't circle the answers


        // Problem 1
        // 180 degrees is pi radians
        // 180 = pi * R
        // 180/pi = R
        // using a calculator to determine 180/pi...
        // *** one radian is 57.296 degrees (rounded to nearest .001) ***


        // Problem 2
        // To figure out 60 degrees in radians, we take (Radians/PI)*180, which will equal our degrees
        // 60 = (R/pi)*180
        // 0.333333 = R/pi
        // Multiplying 1/3 (60/180) by pi tells us that...
        // *** 60 degrees is 1.047 radians (rounded to nearest .001) ***


        // Problem 3
        public double RadiansToDegrees(float radians)
        {
            return (radians / Math.PI) * 180;
        }
        public double DegreesToRadians(float degrees)
        {
            return (degrees/180) * Math.PI;
        }


        // Problem 4
        // They would have had to space the stakes out at 3, 4, and 5 knots, not just anywhere on the rope.
        // If they laid the stakes out this way, then they would have a right angle, as one side would be the length
        // between 3 knots, one would be the length between 4, and one the length between 5.
        // Thus, if we use the Pythagorian theorum, 3^2 + 4^2 = 5^2, or 9 + 16 = 25, which is correct, so
        // the triangle would be a right triangle, and the angle across from the length of 5 knots would be 90 degrees


        // Problem 5
        // Cosine rule = CosA = (b^2 + c^2 - a^2) / 2 * b * c
        // CosA = (3^2 + 5^2 - 4^2) / 2 * 3 * 5
        // CosA = (9 + 25 - 16) / 30
        // CosA = 18 / 30
        // CosA = 0.6
        // A = cos^-1 * 0.6
        // Using a calculator, you find that angle A is 53.1301 degrees
        // Since the sum of the angles of a triangle always equal 180...

        //  *** 180 - 90 - 53.1301 is 36.8699 (rounded to nearest .001) degrees for our last angle ***


        // Problem 6
        // We know two sides and an angle, so we will use the sine rule
        // a/SinA = b/SinB = c/SinC
        // Due to the transitive property, we don't need to have all three equations listed
        // A calculator is used to determine the sine of angles below
        // x/Sin(79) = 13/Sin(37)
        // x/0.9816 = 21.6013

        // *** side x = 21.2044 (rounded to nearest .001) ***


        // Problem 7
        // We know all three sides but no angles, so we will use the cosine rule
        // cosA = (b^2 + c^2 - a^2) / 2 * b * c
        // cosA = (6^2 + 9^2 - 8^2) / 2 * 6 * 9
        // cosA = (36 + 81 - 64) / 108
        // cosA = 53 / 108
        // cosA = 0.4907
        // A = cos^-1 * 0.4907

        // *** angle A = 60.6107 degrees (rounded to nearest .001) ***


        // Problem 8
        static void CosineRule(double a, double b, double c)
        {
            double A = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            double B = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
            double C = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
            Console.WriteLine($"Angle A = {A} degrees");
            Console.WriteLine($"Angle B = {B} degrees");
            Console.WriteLine($"Angle C = {C} degrees");
        }

        static void Main()
        {
            CosineRule(1,2,3);
            Console.ReadKey();
        }

    }
}
