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
            //store the count in temp  variable
            Node<Gtype> temp_node;

            //creating new node with data
            Node<Gtype>node = new Node<Gtype>(data);

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
                temp_node.next = node;
            }
        }

        public void Display()
        {
            if (head is null)
            {
                Console.WriteLine("List is empty..");
                return;
            }
            else
            {
                //created temp variable and the node display start from head 
                Node<Gtype> temp_node = head;
                //displaying head as we had head value 
                Console.WriteLine(temp_node.value);
                //display upto ---> node is not equal to null
                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.value);
                    temp_node = temp_node.next;
                }
            }
        }
    }



    
}
