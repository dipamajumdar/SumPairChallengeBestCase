using System;

namespace SumPairOptimized
{
    class Program
    {
        public static void Main(string[] args)
        {
            //enter length of array
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] indicesArr = new int[n];

            //input target value
            Console.WriteLine("Enter target interger value:");
            int targetValue = Convert.ToInt32(Console.ReadLine());

            //input array
            Console.WriteLine("Enter array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Logic to calculate indices of elements pair that sums to targetValue value
            int diff = 0;
            int j = 0;
            for (int i = 0; i < (n/2); i++)
            {
                diff = targetValue - arr[i];
                indicesArr[j] = i;
                indicesArr[j+1] = Array.FindIndex(arr, x => x == diff);
                j=j+2;
            }

            Console.WriteLine("Indices of elements pair that sums to targetValue value is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(indicesArr[i]);
            }
        }
    }
}
