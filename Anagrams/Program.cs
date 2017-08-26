using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "listen is";
            string str2 = "silent is";
            //bool anagram = false;

            char[] characters1 = str1.ToCharArray();
            char[] characters2 = str2.ToCharArray();

            Array.Sort(characters1);
            Array.Sort(characters2);

            string test1 = (new string(characters1)).ToLower();
            string test2 = (new string(characters2)).ToLower();
                     
            string newtest = test1.Trim(' ');
            string newtest2 = test2.Trim(' ');

            if (newtest.Equals(newtest2))
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
            //Console.WriteLine(newtest);
            //Console.WriteLine(newtest2);
            Console.ReadLine();

        }
    }
}
