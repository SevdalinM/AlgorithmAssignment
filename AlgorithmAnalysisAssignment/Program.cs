using System;
using System.Collections.Generic;
using System.Linq;
namespace AlgorithmAnalysisAssignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ManageArrays manage = new ManageArrays();
            manage.populateArrays();
            //manage.displayArrays();
            manage.algorithmA(manage.listOfArrays[0]);
        }

        class ManageArrays 
        {
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
                int[] array1 = new int[array.Length/2];
                int[] array2 = new int[array.Length/2];
                array1=array.Take((array.Length) / 2).ToArray();
                array2=array.Skip((array.Length) / 2).ToArray();
                Console.WriteLine(array[0]);
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
}
