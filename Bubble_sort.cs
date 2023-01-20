using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Concept
{
    public class Bubble_sort
    {
        public Bubble_sort()
        {
            int[] arr = { 34, 65, 4, 66, 37 };
            int temp;
            for(int j=0;j<=arr.Length-2;j++)
            {
                for(int i=0;i<=arr.Length-2;i++)
                {
                    if (arr[i]>arr[i+1] )
                    {
                        temp=arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Array is sorted by bubble sort:");
            foreach(int ele in arr)
            {
                Console.WriteLine(ele);
            }
        
        }
    }
}
