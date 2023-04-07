using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmAnalysisAssignment
{
    internal class AlgorithmH
    {
        public void executeAlgorithm(int[] array)
        {
            int bestDiff = array.Sum();
            int[] bestLeft = new int[array.Length];
            int[] bestRight = new int[array.Length];

            for (int i = 0; i < (1 << array.Length); i++)
            {
                int[] part1 = new int[array.Length];
                int[] part2 = new int[array.Length];
                int sum1 = 0;
                int sum2 = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        part1[sum1] = array[j];
                        sum1 += 1;
                    }
                    else
                    {
                        part2[sum2] = array[j];
                        sum2 += 1;
                    }
                }

                Array.Resize(ref part1, sum1);
                Array.Resize(ref part2, sum2);

                int diff = Math.Abs(part1.Sum() - part2.Sum());

                if (diff < bestDiff)
                {
                    bestLeft = part1;
                    bestRight = part2;
                    bestDiff = diff;
                }
            }

            Console.WriteLine("Minimum difference: " + bestDiff);
            for (int i = 0; i < bestLeft.Length; i++)
            {
                Console.WriteLine("S1: " + bestLeft[i]);
            }

            for (int i = 0; i < bestRight.Length; i++)
            {
                Console.WriteLine("S2: " + bestRight[i]);
            }

        }
    }
}
