using System;
using System.Collections.Generic;

namespace DataStructureProblems
{/// <summary>
/// Template for testing link list
/// </summary>
    class Program
    {/// <summary>
     /// UC4 - Inserting elements in middle of linked list
     /// </summary>

        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(56);
            myList.Add(70);
            Console.WriteLine("Linked list before Insertion:");
            myList.Display();
            myList.InsertMid(30, 2);
            Console.WriteLine("Linked list after Insertion:");
            myList.Display();


        }
    }
}
