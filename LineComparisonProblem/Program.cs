using System;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Line Comparison Problem");
            Console.WriteLine(" Enter 0 For Display Welcome to Line Comparison \n Enter 1 For Calculate the lenght of line based on points consisting of (X,Y) co-ordinates");
            int option = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            switch (option)
            {

                case 0:
                    Console.WriteLine(" Welcome to Line Comparison");
                    break;
                case 1:
                    Console.WriteLine("Please Enter X1 & Y1 Co-Ordinates:");
                    var X1 = Convert.ToDouble(Console.ReadLine());
                    var Y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter X2 & Y2 Co - Ordinates:");
                    var X2 = Convert.ToDouble(Console.ReadLine());
                    var Y2 = Convert.ToDouble(Console.ReadLine());
                    LengthOfLineUC1.LengthUC1(X1, Y1, X2, Y2);
                    break;
                default:
                    Console.WriteLine("Please Input Correct option");
                    break;

            }
        }
    }
}
