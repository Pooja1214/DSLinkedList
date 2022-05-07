using System;
using System.Collections.Generic;

namespace DataStructureProblems
{/// <summary>
/// Template for testing link list
/// </summary>
    class Program
    {/// <summary>
     /// UC8 - Adding element in between in LinkedList 
     /// </summary>

        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.Add(56);
            myList.Add(30);
            myList.Add(70);
            Console.WriteLine("Before");
            myList.Display();
            myList.Add(40, 3);
            Console.WriteLine("after position adding");
            myList.Display();
        }
    }
}
