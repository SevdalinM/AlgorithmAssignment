using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAnalysisAssignment
{
    internal class AlgorithmA
    {
        public void executeAlgorithm(int[] array)
        {
            int[] array1 = array.Take((array.Length) / 2).ToArray();
            int[] array2 = array.Skip((array.Length) / 2).ToArray();
            int difference = Math.Abs(array1.Sum() - array2.Sum());

            Console.WriteLine("Difference between arrays: " + difference);

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("S1: " + array1[i]);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("S2: " + array2[i]);
            }
        }
    }
}
