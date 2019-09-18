using System;
using System.Collections.Generic;

namespace Algorithms.Amazon
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node() { }
        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }

    public class CopyRandomListClass
    {
        Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            Node newNode;
            if (head == null)
                return null;

            if (visited.ContainsKey(head))
            {
                return visited.GetValueOrDefault(head);
            }
            else
            {
                newNode = new Node(head.val, null, null);
                visited.Add(head, newNode);

                newNode.next = CopyRandomList(head.next);
                newNode.random = CopyRandomList(head.random);
            }

            return newNode;
        }

        public Node CopyRandomListIterative(Node head)
        {
            Node oldHead = head;
            Node newNode = new Node(oldHead.val, null, null);


            while(oldHead != null)
            {
                newNode.random = this.getClonedNode(oldHead.random);
                newNode.next = this.getClonedNode(oldHead.next);
                oldHead = oldHead.next;
                newNode = newNode.next;
            }

            return visited.GetValueOrDefault(head);
        }

        public Node getClonedNode(Node node)
        {
            // If the node exists then
            if (node != null)
            {
                // Check if the node is in the visited dictionary
                if (visited.ContainsKey(node))
                {
                    // If its in the visited dictionary then return the new node reference from the dictionary
                    return visited.GetValueOrDefault(node);
                }
                else
                {
                    // Otherwise create a new node, add to the dictionary and return it
                    visited.Add(node, new Node(node.val, null, null));
                    return visited.GetValueOrDefault(node);
                }
            }
            return null;
        }
    }
}
