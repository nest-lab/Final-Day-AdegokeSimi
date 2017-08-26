using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastFromTheBack
{
    class Program
    {
        static void Main(string[] args)
        {
            //third from last element in an array
            int[] myArray = { 1, 2, 3, 4, 5, 9,10,12, 15,37 ,98, 08};
                       
            Console.WriteLine(myArray[myArray.Length - 3]);
            Console.ReadLine();
        }
    }
}
