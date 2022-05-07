using System;
using System.Collections.Generic;

namespace DataStructureProblems
{/// <summary>
/// Template for testing link list
/// </summary>
    class Program
    {/// <summary>
     /// UC6 - Delete Last element of linked list Using pop pos
     /// </summary>

        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.push(56);
            myList.push(30);
            myList.push(70);
            myList.Show();
            //Console.WriteLine("Linked list before Insertion:");
            //myList.Display();
            //myList.InsertMid(30, 2);
            //Console.WriteLine("Linked list after Insertion:");
            //myList.Display();
            //Console.WriteLine("After pop Method");
            //myList.Pop();
            //myList.Display();
            Console.WriteLine("After last position is removed");
            myList.pop_pos(2);
            myList.Show();
            


        }
    }
}
