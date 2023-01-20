using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Concept
{
    public class BinarySearch
    {
        public int FindElementByBinarySearch()
        {
            var arr = new[] { 0, 4, 7, 10, 14, 23, 45, 47, 53 };
            var index = 45;
            int left = 0;
            int right=arr.Length- 1;
            int mid = 0;
            Console.WriteLine("The array elements are: ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("We are searching index of element: "+index);
            while(left<= right)
            {
                mid= (left+right)/2;
                if (arr[mid]==index)
                {
                    //Console.WriteLine("The element is present on index: " + mid);
                    return mid+1;
                }
                else if (arr[mid]>index)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
