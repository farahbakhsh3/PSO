using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO
{
    class clsFitness
    {
        public clsFitness()
        {
            // nothing needed.
        }

        public double funcFitness(double[] xx, int cFunc)
        {
            double y = 0;
            switch (cFunc)
            {
                case 0:
                    y = funcFitness0(xx);
                    break;
                case 1:
                    y = funcFitness1(xx);
                    break;
                case 2:
                    y = funcFitness2(xx);
                    break;
                case 3:
                    y = funcFitness3(xx);
                    break;
                case 4:
                    y = funcFitness4(xx);
                    break;
                case 5:
                    y = funcFitness5(xx);
                    break;
                case 6:
                    y = funcFitness6(xx);
                    break;
                default:
                    y = 0;
                    break;
            }
            return y;
        }

        private double funcFitness0(double[] xx)
        {
            double y = 0;
            double c = 2 * Math.PI;
            double b = 0.2;
            double a = 20;
            double sum1 = 0;
            double sum2 = 0;
            double t1;
            double t2;
            int d = xx.Length;
            for (int i = 0; i < d; i++)
            {
                sum1 = sum1 + xx[i] * xx[i];
                sum2 = sum2 + Math.Cos(c * xx[i]);
            }
            t1 = -a * Math.Exp(-b * Math.Sqrt(sum1 / d));
            t2 = -Math.Exp(sum2 / d);
            y = t1 + t2 + a + Math.Exp(1);
            return y;
        }

        private double funcFitness1(double[] xx)
        {
            double s = -(1 + Math.Cos(12 * Math.Sqrt(xx[0] * xx[0] +
                xx[1] * xx[1]))) / (.5 * (xx[0] * xx[0] + xx[1] * xx[1]) + 2);

            return s;
        }

        private double funcFitness2(double[] xx)
        {
            int d = xx.Length;
            double sum = 0;

            for (int i = 0; i < d; i++)
            {
                sum += xx[i] * xx[i];
            }
            return sum;
        }

        private double funcFitness3(double[] xx)
        {

            double x1 = xx[0];
            double x2 = xx[1];

            double term1 = 100 * Math.Sqrt(Math.Abs(x2 - 0.01 * x1 * x1));
            double term2 = 0.01 * Math.Abs(x1 + 10);

            double y = term1 + term2;
            return y;
        }

        private double funcFitness4(double[] xx)
        {

            double x1 = xx[0];
            double x2 = xx[1];

            double frac1 = 1 + Math.Cos(12 * Math.Sqrt(x1 * x1 + x2 * x2));
            double frac2 = 0.5 * (x1 * x1 + x2 * x2) + 2;

            double y = -frac1 / frac2;
            return y;
        }

        private double funcFitness5(double[] xx)
        {
            int d = xx.Length;
            double[] w = new double[d];
            for (int ii = 0; ii < d; ii++)
                w[ii] = 1 + (xx[ii] - 1) / 4;

            double term1 = Math.Pow((Math.Sin(Math.PI * w[0])), 2);
            double term3 = Math.Pow((w[d - 1] - 1), 2) * (1 + Math.Pow((Math.Sin(2 * Math.PI * w[d - 1])), 2));

            double sum = 0;
            double wi;
            double _new;
            for (int ii = 0; ii < d - 1; ii++)
            {
                wi = w[ii];
                _new = Math.Pow((wi - 1), 2) * (1 + 10 * Math.Pow((Math.Sin(Math.PI * wi + 1)), 2));
                sum = sum + _new;
            }

            double y = term1 + sum + term3;
            return y;
        }

        private double funcFitness6(double[] xx)
        {
            int d = xx.Length;
            double sum = 0;
            double xi;
            for (int ii = 0; ii < d; ii++)
            {
                xi = xx[ii];
                sum = sum + ((xi * xi) - 10 * Math.Cos(2 * Math.PI * xi));
            }            
            double y = 10 * d + sum;
            return y;
        }
    }
}