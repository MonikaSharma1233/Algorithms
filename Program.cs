namespace Sorting_Concept
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Bubble_sort bs=new Bubble_sort();
            //  Insertion_Sort isobj=new Insertion_Sort();
           // Anagram anagram= new Anagram();
            //anagram.CheckAnagram();
            BinarySearch binarySearch=new BinarySearch();
            int index=binarySearch.FindElementByBinarySearch();
            Console.WriteLine("The element is present on index: " + index);   
        }
    }
}
