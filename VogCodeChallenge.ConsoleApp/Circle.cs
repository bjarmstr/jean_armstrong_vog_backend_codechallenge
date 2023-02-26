using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.ConsoleApp
{
    public sealed class Circle
    {
        private double radius;

        public double CalculateDiameter(Func<double, double> operation)
        {
            return operation(radius);
        }

    }
}
