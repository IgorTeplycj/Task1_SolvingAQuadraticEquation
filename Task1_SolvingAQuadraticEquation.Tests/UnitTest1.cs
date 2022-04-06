using NUnit.Framework;
using System.Linq;

namespace Task1_SolvingAQuadraticEquation.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoSolve()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 1;
            double b = 0;
            double c = 1;

            double[] solve = quadraticEquation.Solve(a, b, c);

            Assert.IsNull(solve);
        }

        [Test]
        public void OneSolve()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 1;
            double b = 2;
            double c = 1;

            double[] solve = quadraticEquation.Solve(a, b, c);

            Assert.IsNotNull(solve);
            Assert.AreEqual(solve.Length, 1);

            double expected = solve.First();
            Assert.AreEqual(expected, (double)-1);
        }
    }
}