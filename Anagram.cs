using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Concept
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] chararr1=str1.ToLower().ToCharArray();
            char[] chararr2=str2.ToLower().ToCharArray();
            Array.Sort(chararr1);
            Array.Sort(chararr2);
            string newarray1=new string(chararr1);
            string newarray2=new string(chararr2);

            if(newarray1==newarray2)
            {
                Console.WriteLine("Strings are Anagrams.");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams.");
            }
        }
    }
}
