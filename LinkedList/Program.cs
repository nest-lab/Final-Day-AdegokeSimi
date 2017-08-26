using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> shoppingList = new LinkedList<string>();
            shoppingList.AddFirst("Milk");

            LinkedListNode<string> node = shoppingList.Find("Milk");

            shoppingList.AddBefore(node, "Bread");
            shoppingList.AddAfter(node, "Tead");
            shoppingList.AddLast("Ginger");

            foreach (var item in shoppingList)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
   
}
