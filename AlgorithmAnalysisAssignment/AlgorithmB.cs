using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAnalysisAssignment
{
    internal class AlgorithmB
    {
        public void executeAlgorithm(int[] array)
        {
            int[] evenArray = new int[array.Length / 2];
            int[] oddArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {   //even
                    evenArray[i / 2] = array[i];
                }
                else
                {   //odd
                    oddArray[i / 2] = array[i];
                }
            }

            int difference = Math.Abs(evenArray.Sum() - oddArray.Sum());
            Console.WriteLine("Difference between arrays: " + difference);

            for (int i = 0; i < evenArray.Length; i++)
            {
                Console.WriteLine("S1: " + evenArray[i]);
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.WriteLine("S2: " + oddArray[i]);
            }
        }

    }
}
