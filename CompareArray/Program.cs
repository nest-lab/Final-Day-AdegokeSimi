using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5,6 };
            int[] array2 = { 2, 3, 1, 0, 5 };

            List<int> newArray = new List<int>();
            newArray = array1.ToList();

            List<int> found = new List<int>();
            List<int> Notfound = new List<int>();

            foreach (var num1 in array1)
            {
                foreach (var num2 in array2)
                {
                    if (num1 == num2)
                    {
                        found.Add(num1);
                    }
                    else
                    {
                        Notfound.Add(num1);
                    }
               }
            }

        
            foreach (var item in array1)
            {
                foreach (var item1 in found)
                {
                    if (item == item1)
                    {
                        newArray.Remove(item);
                    }
                }
            }

            //
            Console.WriteLine("The following element cannot be found;");
            foreach (var item in newArray)
            {
                
                Console.WriteLine(item);
            }
           
            Console.ReadLine();
           
        }
    }
}
