using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHighest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array2 = { 2, 3, 1, 0, 5,10,98,79 };

            int[] newArray = array2.OrderByDescending(c => c).ToArray();
            
            Console.WriteLine(newArray[1]);
            Console.ReadLine();
        }
    }
}
