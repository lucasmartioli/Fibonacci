using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciSolve.IteractiveSolution(35));
            Console.WriteLine(FibonacciSolve.EfficientInteractiveSolution(35));
        }
    }

    public class FibonacciSolve
    {
        public static int IteractiveSolution(int n)
        {
            var i = 1;
            var j = 0;

            for (var k = 1; k <= n; k++)
            {
                //Console.WriteLine(j);
                var t = i + j;
                i = j;
                j = t;
            }

            return j;
        }

        public static int EfficientInteractiveSolution(int n)
        {
            if (n <= 0)
                return 0;

            var i = n - 1;
            var a = 1;
            var b = 0;
            var c = 0;
            var d = 1;
            while (i > 0)
            {
                var aux1 = 0;
                var aux2 = 0;
                if (i % 2 != 0)
                {
                    aux1 = d * b + c * a;
                    aux2 = d * (b + a) + c * b;
                    a = aux1;
                    b = aux2;
                }

                aux1 = c * c + d * d;
                aux2 = d * (2 * c + d);
                c = aux1;
                d = aux2;
                i = i / 2;
            }

            return a + b;
        }
    }
}
