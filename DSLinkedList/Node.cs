using System;
using System.Collections.Generic;
namespace DataStructureProblems
{
    public class Node<Gtype>
    {
        public Gtype value;
        public Node<Gtype> next;

        public Node(Gtype data)
        {
            this.value = data;
            this.next = null;
        }
    }
}
