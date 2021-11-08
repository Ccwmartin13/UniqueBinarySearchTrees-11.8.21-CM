using System;
using System.Numerics;

namespace UniqueBinarySearchTrees_11._8._21_CM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int totalBinarySearchTrees = NumTrees(19);

                Console.WriteLine(totalBinarySearchTrees);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred: " + ex.Message);
            }
        }

        public static int NumTrees(int n)
        {
            if (n < 1 || n > 19)
            {
                throw new Exception("Number cannot be smaller than 1 or larger than 19.");
            }
            else
            {
                BigInteger numerator = factorial(2 * n), denominator = factorial(n + 1) * factorial(n);
                return (int)(numerator / denominator);
            }
        }

        private static BigInteger factorial(int n)
        {
            return n == 0 ? 1 : n * factorial(n - 1);
        }
    }
}
