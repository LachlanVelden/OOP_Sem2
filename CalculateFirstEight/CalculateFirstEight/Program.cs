using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFirstEight
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibs = new List<int>();
            var primes = new List<int>();

            while (true)
            {



            }
            

        }
    }

    static class Helpers
    {
        /// <summary>
        /// Get n Fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <remarks>From: https://www.dotnetperls.com/fibonacci </remarks>
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        /// <summary>
        /// Get n Prime Number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <remarks> from: https://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers </remarks>
        public static int GeneratePrimes(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);

                bool isPrime = true;

                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes.Last();
        }
    }
}
