using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAnalysisAssignment
{
    internal class AlgorithmG
    {
        public void executeAlgorithm(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);

            int[] array1 = new int[array.Length];
            int[] array2 = new int[array.Length];
            array1[0] = array[0];
            array2[0] = array[1];
            int sumArr1 = array1.Sum();
            int sumArr2 = array2.Sum();
            int arr1Index = 1;
            int arr2Index = 1;

            for (int i = 2; i < array.Length; i++)
            {
                if (sumArr1 < sumArr2)
                {
                    array1[arr1Index] = array[i];
                    arr1Index++;
                    sumArr1 = array1.Sum();
                }
                else
                {
                    array2[arr2Index] = array[i];
                    arr2Index++;
                    sumArr2 = array2.Sum();
                }
            }

            Array.Resize(ref array1, arr1Index);
            Array.Resize(ref array2, arr2Index);

            int difference = Math.Abs(array1.Sum() - array2.Sum());
            Console.WriteLine("Difference between arrays: " + difference);

            Console.WriteLine("The Sum of S1: " + array1.Sum());
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("S1: " + array1[i]);
            }
            Console.WriteLine("The Sum of S2: " + array2.Sum());
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("S2: " + array2[i]);
            }
        }

    }
}
