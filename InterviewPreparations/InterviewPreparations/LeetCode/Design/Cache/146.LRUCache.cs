using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    /// <summary>
    //  Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.
    //  get(key) - Get the value(will always be positive) of the key if the key exists in the cache, otherwise return -1.
    //  put(key, value) - Set or insert the value if the key is not already present.When the cache reached its capacity, it should invalidate the least 
    //  recently used item before inserting a new item.Follow up:
    //  Could you do both operations in O(1) time complexity? Solution REF : https://alaindefrance.wordpress.com/2014/10/05/lru-cache-implementation/
    // </summary>
    #region Explanation in Simple words
        //1. LRU cache needs Double linked list and Dictionary
        //2. Declare doubly linked list 
        //3. In LRU class, declare dictionary with key and doubly linked list node
        //4. In LRU class constructor, initialize begin and end nodes and hook them up
        //5. we need below methods to implement LRU cache
              //- AddNodeAfterHead - to add nodes in cache
              //- RemoveNode - to remove node from cache
              //- ItemAccess - first remove and add it in front of the list or after head
              //- RemoveLast - to clean up the cache when there is new item to add and space is not available for new item
              //- Get - get the item from cache
              //- Put - update/create cache item
    #endregion
    public class LRUCache
    {
        //declare the cache mapping as Dictionary with key and Node
        IDictionary<int, Node> cacheMapping;

        int capacity;
        int count;

        Node head;
        Node end;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            count = 0;
            this.cacheMapping = new Dictionary<int, Node>();

            //at the begining initialize head node 
            head = new Node();
            head.previous = null;

            //at the begining initialize end node
            end = new Node();
            end.next = null;

            //hook the head and end node in the list
            //all the elements will be placed within these two nodes
            head.next = end;
            end.previous = head;
        }

        public void addNodeAfterHead(Node node)
        {
            //link the previous to head
            node.previous = head;

            //link the next to head next
            node.next = head.next;

            //link head.next.previous node
            head.next.previous = node;

            //head next is also equal node
            head.next = node;
        }

        public void RemoveNode(Node node)
        {
            Node next = node.next;
            Node previous = node.previous;

            previous.next = next;
            next.previous = previous;
        }

        //Below method will help adjusting cache for any hits
        public void ItemAccessFromCache(Node node)
        {
            //Remove the item from cache
            RemoveNode(node);

            //Move it to front list
            addNodeAfterHead(node);
        }

        //that will be used to clean up the oldest item
        public Node RemoveLast()
        {
            Node deletedNode = end.previous;
            RemoveNode(deletedNode);

            return deletedNode;
        }

        //get the element from cache
        public int Get(int key)
        {
            if(cacheMapping.ContainsKey(key))
            {
                Node node = cacheMapping[key];

                //Now move the item to the first place after reading it
                ItemAccessFromCache(node);

                return node.value;
            }

            //Not found
            return -1;
        }

        //save the element in cache
        public void Put(int key, int value)
        {
            //If key is already there, need to update the cache slot
            if(cacheMapping.ContainsKey(key))
            {
                Node exisitngNode = cacheMapping[key];
                exisitngNode.value = value;

                ////Now move the item to the first place after reading it
                ItemAccessFromCache(exisitngNode);
                return;
            }

            //Lets check for the capacity as well, before adding item to new slot
            if (count >= capacity)
            {
                //int id = this.end.key;

                //Remove oldest item from cache to free up some slots for new items
                Node deletedNode  = RemoveLast();

                //Remove the element from caching mapping storage as well
                cacheMapping.Remove(deletedNode.key);

                count--;
            }

            //Add item to new slot
            Node node = new Node();
            node.key = key;
            node.value = value;
            addNodeAfterHead(node); //add node in the cache
            // cacheMapping[key] = node; // add key in the cache mapping storage
            cacheMapping.Add(key, node);
            count++;
        }
    }

    // this is doubly Linked Linked Initialization Class
    public class Node
    {
        public int key; // this is the key
        public int value; // this is the value of cache
        public Node previous;
        public Node next;
    }
}
