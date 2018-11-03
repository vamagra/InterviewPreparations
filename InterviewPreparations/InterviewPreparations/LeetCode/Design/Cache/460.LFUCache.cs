using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    /// <summary>
    //  Design and implement a data structure for Least Frequently Used (LFU) cache. It should support the following operations: get and put.
    //  get(key) - Get the value(will always be positive) of the key if the key exists in the cache, otherwise return -1.
    //  put(key, value) - Set or insert the value if the key is not already present.When the cache reaches its capacity, it should invalidate the least frequently used item before inserting a new item.For the purpose of this problem, when there is a tie (i.e., two or more keys that have the same frequency), the least recently used key would be evicted.
    //  Follow up:
    //  Could you do both operations in O(1) time complexity?
    //  Example:
    //  LFUCache cache = new LFUCache( 2 /* capacity */ );
    //  cache.put(1, 1);
    //  cache.put(2, 2);
    //  cache.get(1);       // returns 1
    //  cache.put(3, 3);    // evicts key 2
    //  cache.get(2);       // returns -1 (not found)
    //  cache.get(3);       // returns 3.
    //  cache.put(4, 4);    // evicts key 1.
    //  cache.get(1);       // returns -1 (not found)
    //  cache.get(3);       // returns 3
    //  cache.get(4);       // returns 4
    /// </summary>
    public class LFUCache
    {
        //declare the cache mapping as Dictionary with key and Node
        IDictionary<int, Node> cacheMapping;

        int capacity;

        Node head;
        Node end;
        
        public LFUCache(int capacity)
        {
            this.capacity = capacity;
            cacheMapping = new Dictionary<int, Node>();

            //at the begining initialize head node 
            head = new Node();
            head.freq = int.MaxValue;
            head.key = -1;
            head.value = -1;
            head.prev = null;

            //at the begining initialize end node
            end = new Node();
            end.freq = int.MaxValue;
            end.key = -1;
            end.value = -1;
            end.next = null;

            //hook the head and end node in the list
            //all the elements will be placed within these two nodes
            head.next = end;
            end.prev = head;
        }

        public void addNodeAfterHead(Node node)
        {
            //link the previous to head
            node.prev = head;

            //link the next to head next
            node.next = head.next;

            //link head.next.previous node
            head.next.prev = node;

            //head next is also equal node
            head.next = node;
        }

        public void removeNode(Node node)
        {
            Node next = node.next;
            Node prev = node.prev;

            next.prev = prev;
            prev.next = next;
        }

        public void itemAccessFromCache(Node node)
        {
            removeNode(node);
            addNodeAfterHead(node);
        }

        public int Get(int key)
        {
            if (cacheMapping.ContainsKey(key))
            {
                Node node = cacheMapping[key];

                // increase the node count
                node.freq++;

                // update the position of Node
                itemAccessFromCache(node);

                return cacheMapping[key].value;
            }

            // Not Found
            return -1;
        }

        public void Put(int key, int value)
        {
            Node node = null;

            if (cacheMapping.ContainsKey(key))
            {
                node = cacheMapping[key];
                node.value = value;
                node.freq++;

                itemAccessFromCache(node);
                return;
            }
            else
            {
                // remove old key from cache
                if (cacheMapping.Count >= capacity)
                {
                    int minKey = -1;
                    int minCount = int.MaxValue;

                    Node curr = head;

                    // loop through the list of Doubly linked list and get the min freq count key
                    while (curr != end)
                    {
                        if (curr.freq <= minCount)
                        {
                            minCount = curr.freq;
                            minKey = curr.key;
                        }

                        curr = curr.next;
                    }

                    // if min Key is not -1, then remove that item from cache
                    if (minKey != -1)
                    {
                        Node lessFreqNode = cacheMapping[minKey];
                        removeNode(lessFreqNode);

                        cacheMapping.Remove(lessFreqNode.key);
                    }
                }
            }

            // add new node in the list
            node = new Node();

            node.key = key;
            node.value = value;
            node.freq = 1;
            node.next = null;
            node.prev = null;

            if (cacheMapping.Count < capacity)
            {
                cacheMapping.Add(key, node);
                addNodeAfterHead(node);
            }
        }
    }

    public class Node
    {
        public int key;
        public int value;
        public Node prev;
        public Node next;
        public int freq;
    }
}
