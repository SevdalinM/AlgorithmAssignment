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
            AlgorithmA algorithmA = new AlgorithmA();
            AlgorithmB algorithmB = new AlgorithmB();  
            AlgorithmC algorithmC = new AlgorithmC(); 
            AlgorithmD algorithmD = new AlgorithmD();
            AlgorithmE algorithmE = new AlgorithmE();
            AlgorithmF algorithmF = new AlgorithmF();   
            AlgorithmG algorithmG = new AlgorithmG();
            AlgorithmH algorithmH = new AlgorithmH();
            AlgorithmI algorithmI = new AlgorithmI();
            AlgorithmIv2 algorithmIv2 = new AlgorithmIv2();

            ManageArrays manage = new ManageArrays();
            

            manage.populateArrays();

            //for (int i = 0; i < manage.arr16.Length; i++)
            //{
            //    Console.WriteLine("Arr" + manage.arr16.Length + ": " + manage.arr16[i] + " N:" + (i + 1));
            //}

            //Console.WriteLine("Min Diff: " +
            //algorithmIv2.minDifference(manage.staticArray, manage.staticArray.Length));


            //algorithmI.printEqualSumSets(manage.arr32, manage.arr32.Length);

            algorithmB.executeAlgorithm(manage.arr16);
            algorithmE.executeAlgorithm(manage.arr16);
        }

        class ManageArrays 
        {
            public int[] staticArray = new int[] {4,5,1,3,7,10,10,14};
            public List<int> integers = new List<int>();


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

        }
        

    }
}
