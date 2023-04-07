using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAnalysisAssignment
{
    internal class AlgorithmC
    {
        public void executeAlgorithm(int[] array)
        {
            int[] evenValues = new int[array.Length];
            int[] oddValues = new int[array.Length];

            //separate indexes initialised to 0, to ensure the new values are added to the next available container
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {   //even
                    evenValues[evenIndex] = array[i];
                    //index incremented to make sure the next value is in the next available container
                    evenIndex++;
                }
                else
                {   //odd
                    oddValues[oddIndex] = array[i];
                    oddIndex++;
                }
            }

            //arrays rezised to remove the elemnts not used.
            Array.Resize(ref evenValues, evenIndex);
            Array.Resize(ref oddValues, oddIndex);

            int difference = Math.Abs(evenValues.Sum() - oddValues.Sum());
            Console.WriteLine("Difference between arrays: " + difference);

            for (int i = 0; i < evenValues.Length; i++)
            {
                Console.WriteLine("S1: " + evenValues[i]);
            }

            for (int i = 0; i < oddValues.Length; i++)
            {
                Console.WriteLine("S2: " + oddValues[i]);
            }
        }
    }
}
