using GAF;
using Labworks.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labworks.ExcelAddin
{
    // y(x) = a + bx + cx2 + dx3
    abstract class TargetFunction : TargetFunctionRange, ITargetFunction
    {
        int accuracy;
        double ranging;

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public TargetFunction(double xmin, double xmax)
            : base(xmin, xmax)
        {
        }

        public double CalculateX(double N) { return N * (XMax - XMin) + XMin; }
        public double CalculateY(double X) { return A + B * X + C * X * X + D * X * X * X; }
        public abstract double CalculateFitness(double Y);

        public void InitializeRanging(Population initialpopulation)
        {
            accuracy = initialpopulation.ChromosomeLength;
            ranging = 2.0 / (System.Math.Pow(2.0, accuracy) - 1.0);
        }

        public double CalculateN(Chromosome genes)
        {
            var rawX = Convert.ToInt32(genes.ToBinaryString(0, genes.Count), 2);
            var adjustedX = (rawX * ranging) - 1;
            return adjustedX * 0.5 + 0.5;
        }
    }

    class TargetFunctionMax : TargetFunction
    {
        public override double CalculateFitness(double Y) { return Y / 10000000000.0; }
    }

    class TargetFunctionMin : TargetFunction
    {
        public override double CalculateFitness(double Y) { return 1 - Y / 10000000000.0; }
    }
}
