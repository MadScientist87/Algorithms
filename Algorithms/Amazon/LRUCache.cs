using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Algorithms.Amazon
{
    public class LRUCache
    {

        private Dictionary<int, DLinkedNode> cache =
            new Dictionary<int, DLinkedNode>();
        private int size;
        private int _capacity;
        private DLinkedNode head, tail;
        public class DLinkedNode
        {
            public int key;
            public int value;
            public DLinkedNode prev { get; set; }
            public DLinkedNode next { get; set; }
        }

        private void AddNode(DLinkedNode node)
        {
            node.prev = head;
            node.next = head.next;

            head.next.prev = node;
            head.next = node;


        }

        private void RemoveNode(DLinkedNode node)
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }

        private DLinkedNode PopTail()
        {
            DLinkedNode res = tail.prev;
            RemoveNode(res);
            return res;
        }

        private void MoveToHead(DLinkedNode node)
        {
            RemoveNode(node);
            AddNode(node);
        }

        public LRUCache(int capacity)
        {
            head = new DLinkedNode();
            tail = new DLinkedNode();

            head.next = tail;
            tail.prev = head;
            _capacity = capacity;
        }

        public int Get(int key)
        {
            var node = cache.GetValueOrDefault(key);
            if (node == null)
                return -1;
            MoveToHead(node);
            return node.value;
        }

        public void Put(int key, int value)
        {

            DLinkedNode node = cache.GetValueOrDefault(key);
            if (node == null)
            {

                var addnew = new DLinkedNode { key = key, value = value };
                AddNode(addnew);
                cache.Add(key, addnew);

                size = cache.Count;
                if (size > _capacity)
                {
                    var tail = PopTail();
                    cache.Remove(tail.key);
                }

            }
            else
            {
                node.value = value;
                MoveToHead(node);
            }
        }
    }
}
