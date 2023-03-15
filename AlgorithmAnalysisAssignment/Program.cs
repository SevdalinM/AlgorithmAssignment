using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace AlgorithmAnalysisAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ManageArrays manage = new ManageArrays();
            manage.populateArrays();
            //manage.displayArrays();

            //foreach (int[] array in manage.listOfArrays)
            //{
            //    manage.algorithmH(array, array.Length);
            //}

            manage.algorithmH(manage.arr32, manage.arr32.Length);
        }

        class ManageArrays 
        {
            public int[] staticArray = {4,5,1,3,7,10,10};

            public List<int[]> listOfArrays = new List<int[]>();
            public int[] arr8 = new int[8];
            public int[] arr16 = new int[16];
            public int[] arr32 = new int[32];
            public int[] arr64 = new int[64];
            public int[] arr128 = new int[128];
            public int[] arr256 = new int[256];
            public int[] arr512 = new int[512];
            public int[] arr1024 = new int[1024];
            
            public void populateArrays()
            {
                Random rnd = new Random();
                listOfArrays.Add(arr8);
                listOfArrays.Add(arr16);
                listOfArrays.Add(arr32);
                listOfArrays.Add(arr64);
                listOfArrays.Add(arr128);
                listOfArrays.Add(arr256);
                listOfArrays.Add(arr512);
                listOfArrays.Add(arr1024);

                foreach (int[] array in listOfArrays) 
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(array.Length * 10, array.Length * 100);
                    }
                }

            }
            public void displayArrays() 
            {
                foreach (int[] array in listOfArrays) 
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine("Arr" + array.Length +": " + array[i] + " N:" + (i + 1));
                    }
                }
            }

            public void algorithmA(int[] array)
            {
                int[] array1=array.Take((array.Length) / 2).ToArray();
                int[] array2=array.Skip((array.Length) / 2).ToArray();

                for (int i = 0; i < array1.Length; i++) 
                {
                    Console.WriteLine("S1: " + array1[i]);
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine("S2: " + array2[i]);
                }
            }

            public void algorithmB(int[] array) 
            {
                int[] evenArray = new int[array.Length/2];
                int[] oddArray = new int[array.Length/2];

                for (int i = 0; i < array.Length; i++) 
                {
                    if (i % 2 == 0)
                    {   //even
                        evenArray[i/2]=array[i];
                      
                    }
                    else
                    {   //odd
                        oddArray[i/2] = array[i];
                    }
                }

                for (int i = 0; i < evenArray.Length; i++)
                {
                    Console.WriteLine("S1: " + evenArray[i]);
                }

                for (int i = 0; i < oddArray.Length; i++)
                {
                    Console.WriteLine("S2: " + oddArray[i]);
                }
            }

            public void algorithmC(int[] array) 
            {
                int[] evenValues = new int[array.Length];
                int[] oddValues = new int[array.Length];
                int evenIndex=0;
                int oddIndex=0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {   //even
                        evenValues[evenIndex] = array[i];
                        evenIndex++;
                    }
                    else
                    {   //odd
                        oddValues[oddIndex] = array[i];
                        oddIndex++;
                    }
                }
                Array.Resize(ref evenValues, evenIndex);
                Array.Resize(ref oddValues, oddIndex);
                for (int i = 0; i < evenValues.Length; i++)
                {
                    Console.WriteLine("S1: " + evenValues[i]);
                }

                for (int i = 0; i < oddValues.Length; i++)
                {
                    Console.WriteLine("S2: " + oddValues[i]);
                }
            }

            public void algorithmD(int[] array)  
            {
                int[] array1 = new int[array.Length];
                int[] array2 = new int[array.Length];
                array1[0] = array[0];
                array2[0] = array[1];
                int sumArr1 = array1.Sum();
                int sumArr2= array2.Sum();
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

            public void algorithmE(int[] array) 
            {
                Array.Sort(array);
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

                for (int i = 0; i < evenArray.Length; i++)
                {
                    Console.WriteLine("S1: " + evenArray[i]);
                }

                for (int i = 0; i < oddArray.Length; i++)
                {
                    Console.WriteLine("S2: " + oddArray[i]);
                }
            }

            public void algorithmF(int[] array) 
            {
                Array.Sort (array);

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

            public void algorithmG(int[] array)
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

            public void algorithmH(int[] array, int arrayLength) 
            {
                static int findMinRec(int[] arr, int i, int sumCalculated, int sumTotal) 
                {
                    if (i == 0)
                        return Math.Abs((sumTotal - sumCalculated) - sumCalculated);
                    return Math.Min(findMinRec(arr, i - 1, sumCalculated + arr[i - 1], sumTotal), findMinRec(arr, i - 1, sumCalculated, sumTotal));
                }
                int sumTotal = array.Sum();
                int minRec = findMinRec(array, arrayLength, 0, sumTotal);
                Console.WriteLine("The difference between the two subsets is: " + minRec);
            }
        }
        

    }
}
