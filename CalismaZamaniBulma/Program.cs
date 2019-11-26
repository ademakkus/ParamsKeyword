using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static  System.Console;
using  static System.ConsoleColor;
namespace CalismaZamaniBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = Red;
            Console.WriteLine("ÇALIŞMA ZAMANI TEST ETME");
            ForegroundColor = DarkGreen;
            var sw = new Stopwatch();
            var tmpString="";
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                tmpString += i.ToString();
              //  WriteLine(tmpString);
            }
            sw.Stop();
            Console.WriteLine("Execution time :"+sw.ElapsedMilliseconds);
            var sw2=new Stopwatch();
            sw2.Start();
            var sb=new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString());
                //  WriteLine(tmpString);
            }
            sw2.Stop();
            ForegroundColor = DarkYellow;
            Console.WriteLine("StringbuilderExecution time :" + sw2.ElapsedMilliseconds);
            ReadKey();
        }
    }
}
