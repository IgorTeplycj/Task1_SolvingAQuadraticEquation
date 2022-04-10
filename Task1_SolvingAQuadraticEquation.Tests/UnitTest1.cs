using NUnit.Framework;
using System;
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

        [Test]
        public void EquationNotSquare()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 0;
            double b = 2;
            double c = 1;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void MinDiscriminant()
        {
            double[] factors = GetFactors(0.00000000000001);

            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = factors[0];
            double b = factors[1];
            double c = factors[2];

            double[] solve = quadraticEquation.Solve(a, b, c);

            Assert.IsNotNull(solve);
            Assert.AreEqual(solve.Length, 1);

            double expected = solve.First();
        }

        [Test]
        public void CheckNaNFactorA()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = double.NaN;
            double b = 0;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch(Exception ex)
            {

            }
        }

        [Test]
        public void CheckPosInfFactorA()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = double.PositiveInfinity;
            double b = 0;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckNegInfFactorA()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = double.NegativeInfinity;
            double b = 0;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckNaNFactorB()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = Double.NaN;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckPosInfFactorB()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = Double.PositiveInfinity;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckNegInfFactorB()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = Double.NegativeInfinity;
            double c = 0;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckNaNFactorC()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = 4;
            double c = Double.NaN;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckPosInfFactorC()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = 4;
            double c = Double.PositiveInfinity;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        [Test]
        public void CheckNegInfFactorC()
        {
            QuadraticEquation quadraticEquation = new QuadraticEquation();
            double a = 2;
            double b = 4;
            double c = Double.NegativeInfinity;

            try
            {
                double[] solve = quadraticEquation.Solve(a, b, c);

                Assert.Fail();
            }
            catch (Exception ex)
            {

            }
        }

        double[] GetFactors(double epsilon)
        {
            double a = 1.0;
            double b = 0.0;
            double c = 1.0;

            b = Math.Pow((epsilon + 4), 0.5);

            return new double[] { a,b,c};
        }
    }

}