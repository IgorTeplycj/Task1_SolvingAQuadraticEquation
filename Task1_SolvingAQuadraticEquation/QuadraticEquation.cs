using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_SolvingAQuadraticEquation
{
    public class QuadraticEquation
    {
        public double[] Solve(double a, double b, double c)
        {
            if (a.CompareTo(0) == 0)
                throw new Exception();

            if (Double.IsNaN(a))
                throw new Exception();

            if (Double.IsNaN(b))
                throw new Exception();

            if (Double.IsNaN(c))
                throw new Exception();

            double[] toOutput = null;

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                toOutput = null;
            }
            else if (D - Math.Pow(10, -10) < Double.Epsilon)
            {
                toOutput = new double[1];
                toOutput[0] = (double)((double)-1 * b) / (double)((double)2 * a);
            }
            return toOutput;
        }

    }
}
