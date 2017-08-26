using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1634;
            string numText = number.ToString();
            List<int> charToNum = new List<int>();
            double sum = 0;

            char[] characters = numText.ToCharArray();

            foreach (var item in characters)
            {
                int convertToInt = (int)char.GetNumericValue(item);
                charToNum.Add(convertToInt);
                //Console.WriteLine(item);
                //Console.WriteLine(convertToInt);
            }

            double count = charToNum.Count();
            foreach (var item in charToNum)
            {
                sum = sum + Math.Pow(item, count);
                //Console.WriteLine(item);
            }
            //Console.WriteLine(numText);
            //Console.WriteLine(sum);

            if (number== sum )
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
            Console.ReadLine();

        }
    }
}
