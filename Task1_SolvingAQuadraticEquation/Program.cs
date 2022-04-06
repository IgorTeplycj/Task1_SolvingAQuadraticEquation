using System;

namespace Task1_SolvingAQuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            var vr = quadraticEquation.Solve(1, 2, 1);


            Console.WriteLine("Hello World!");
        }
    }
}
