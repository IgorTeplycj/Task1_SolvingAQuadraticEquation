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
            double[] toOutput = null;

            double D = b * b - 4 * a * c;
            if(D < 0)
            {
                toOutput = null;
            }

            return toOutput;
        }
    }
}
