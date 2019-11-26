using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  static System.Console;
using static System.ConsoleColor;
namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            double average1, average2;
            ForegroundColor = DarkGreen;
            average1 = CalculateAverage(2.54, 4, 123, 78);
            WriteLine("First average : {0}",average1);
            ForegroundColor = DarkRed;
            average2 = CalculateAverage(3, 45, 66, 90, 8);
            WriteLine("Second average : {0}", average2);
            ReadKey();
        }

        static double CalculateAverage(params double[] values)
        {

            double sum = 0;
            ForegroundColor = DarkYellow;
            WriteLine("You sent {0} doubles.",values.Length);
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        
    }
}
