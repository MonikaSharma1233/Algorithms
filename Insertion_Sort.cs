using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Concept
{
    public class Insertion_Sort
    {
        public Insertion_Sort() 
        {
            int[] arr = new int[5] { 9, 43, 5, 29, 15 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Array is:");
            for(i=0;i<n;i++)
            {
                Console.Write(arr[i]+" ");
            }

            for(i=1;i<n;i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[i])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;

                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Sorted Array is:");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

    }
}
