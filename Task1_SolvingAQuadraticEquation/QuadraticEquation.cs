using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_SolvingAQuadraticEquation
{
    public class QuadraticEquation
    {
        private double epsilon = Math.Pow(10.0, -10.0);
        public double[] Solve(double a, double b, double c)
        {
            if (a < epsilon)
                throw new Exception();

            if (Double.IsNaN(a) || Double.IsInfinity(a))
                throw new Exception();

            if (Double.IsNaN(b) || Double.IsInfinity(b))
                throw new Exception();

            if (Double.IsNaN(c) || Double.IsInfinity(c))
                throw new Exception();

            double[] toOutput = null;

            double D = b * b - 4 * a * c;

            //решений нет
            if (D < - epsilon)
            {
                toOutput = null;
            }
            //одно решение
            else if (D < epsilon)
            {
                toOutput = new double[1];
                toOutput[0] = (double)((double)-1 * b) / (double)((double)2 * a);
            }
            return toOutput;
        }

    }
}
