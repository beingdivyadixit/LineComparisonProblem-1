using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class LengthOfLineUC3
    {
        public static void LengthUC3(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
        {
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double lengthOfFirstLine = Math.Sqrt(X + Y);
            double x = Math.Pow((X4 - X3), 2);
            double y = Math.Pow((Y4 - Y3), 2);
            double lengthOfSecondLine = Math.Sqrt(x + y);
            if (lengthOfFirstLine == lengthOfSecondLine)
            {
                Console.WriteLine("Lines are Equal");
            }
            else if (lengthOfFirstLine > lengthOfSecondLine)
            {
                Console.WriteLine("First Line is Greater than Second Line");
            }
            else
            {
                Console.WriteLine("First Line is lesser than Second Line");
            }
        }
    }
}
