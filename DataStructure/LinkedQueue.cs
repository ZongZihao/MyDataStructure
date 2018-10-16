using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedQueue
    {

        //队列的首尾
        private Node head = null;
        private Node tail = null;

        //入队
        public void Enqueue(string value)
        {
            if(tail == null)
            {
                Node newNode = new Node(value, null);
                head = newNode;
                tail = newNode;
            }
            else
            {
                Node newNode = new Node(value, null);
                tail.next = newNode;
                tail = tail.next;
            }
        }

        //出队
        public string Dequeue()
        {
            if (head == null) return null;
            string res = head.data;
            head = head.next;
            if (head == null)
                tail = null;
            return res;
        }

        private class Node
        {
            public string data;
            public Node next;

            public Node(string data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public string GetData()
            {
                return data;
            }
        }

    }

    
}
