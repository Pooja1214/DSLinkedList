using System;
using System.Collections.Generic;
namespace DataStructureProblems
{
    internal class LinkedList<Gtype>
    {
        Node<Gtype> head = null;

        public void Add(Gtype data)
        {
            //variable
            //store the count in the temp_node 
            Node<Gtype> temp_node;

            //creating new node with data
            Node<Gtype> node = new Node<Gtype>(data);

            //there is no node 
            if (head == null)
            {
                //if there is no element so first one is head
                head = node;
                //close the executaion of the function
                return;
            }
            else
            {
                //count start from head
                temp_node = head;
                //checking for null
                while (temp_node.next != null)
                {
                    temp_node = temp_node.next;
                }
                //adding the node to next variable
                temp_node.next = node;
            }
        }
    }  
}
