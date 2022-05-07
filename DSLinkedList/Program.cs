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
            myList.Add(56);
            myList.Add(30);
            myList.Add(70);

            Console.WriteLine(myList.Search(30));
            

        }
    }
}
