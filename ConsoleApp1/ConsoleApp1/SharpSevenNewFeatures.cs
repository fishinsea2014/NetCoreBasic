using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SharpSevenNewFeatures
    {
        public void Show()
        {
            #region Out variables
            {
                this.DoNothing(out int x, out int y);
                Console.WriteLine(x + y);
            }
            #endregion

            #region Pattern matching
            {
                this.PrintStars(null);
                this.PrintStars(8);
                this.PrintStars("s");
                this.Switch(null,3);
                this.Switch(">10", 11);
                this.Switch(">10", 1);
                this.Switch("<10", 1);
            }
            #endregion

            long bigNum = 100_000_000;
            Console.WriteLine($"This is a big numer {bigNum}");

            {
                Console.WriteLine(Fibonacci(7));
                

            }


        }

        #region Local funciton and tuple.
        private int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negative please!", nameof(x));
            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                return (i + i - 1, i - 1);
            }
        } 
        #endregion

        private void Switch(string p, int k)
        {
            switch (p)
            {
                case ">10" when k > 10:
                    Console.WriteLine("Greater than 10");
                    break;
                case "<10" when k < 10:
                    Console.WriteLine("Less than 10");
                    break;
                case String s when s.Length > 3:
                    Console.WriteLine(s);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                case null:
                    Console.WriteLine("null");
                    break;

            }
        }
        /// <summary>
        /// Is-expressions with patterns
        /// </summary>
        /// <param name="p"></param>
        private void PrintStars(object p)
        {
            if (p is null) return;
            if (!(p is int i)) return;
            Console.WriteLine(new string('*',i));
        }

        private void DoNothing(out int x, out int y)
        {
            x = 1;
            y= x+2;
        }
    }
}
