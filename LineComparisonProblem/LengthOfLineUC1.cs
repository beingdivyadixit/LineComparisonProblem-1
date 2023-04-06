using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class LengthOfLineUC1
    {
        public static void LengthUC1(double X1, double Y1, double X2, double Y2)
        {
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double lengthOfLine = Math.Sqrt(X + Y);
            Console.WriteLine("Length Of Line is :" + lengthOfLine);
        }
    }
}
