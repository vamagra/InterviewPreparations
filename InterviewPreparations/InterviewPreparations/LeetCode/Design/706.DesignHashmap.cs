using System.Collections.Generic;

namespace InterviewPreparations.LeetCode.Design
{
    /// <summary>
    //  Design a HashMap without using any built-in hash table libraries.
    //  To be specific, your design should include these functions:
    //  put(key, value) : Insert a(key, value) pair into the HashMap.If the value already exists in the HashMap, update the value.
    //  get(key): Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
    //  remove(key) : Remove the mapping for the value key if this map contains the mapping for the key.
    //  Example:
    //  MyHashMap hashMap = new MyHashMap();
    //  hashMap.put(1, 1);          
    //  hashMap.put(2, 2);         
    //  hashMap.get(1);            // returns 1
    //  hashMap.get(3);            // returns -1 (not found)
    //  hashMap.put(2, 1);          // update the existing value
    //  hashMap.get(2);            // returns 1 
    //  hashMap.remove(2);          // remove the mapping for 2
    //  hashMap.get(2);            // returns -1 (not found) 
    //  Note:
    //  All keys and values will be in the range of[0, 1000000].
    //  The number of operations will be in the range of[1, 10000].
    //  Please do not use the built-in HashMap library.
    //  </summary>
    class DesignHashmap
    {
        List<LinkedListNode>[] buckets;
        int size;

        DesignHashmap()
        {
            size = 1337;
            buckets = new List<LinkedListNode>[size];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<LinkedListNode>();
            }
        }

        private void put(int key, int value)
        {
            LinkedListNode node = get(getHash(key), key);

            if (node == null)
            {
                buckets[getHash(key)].Add(new LinkedListNode(key, value));
            }
            else
            {
                node.value = value;
            }
        }

        private void Remove(int key)
        {
            LinkedListNode node = get(getHash(key), key);

            if(node==null)
            {
                return;
            }
            else
            {
                buckets[getHash(key)].Remove(node);
            }
        }

        private int get(int key)
        {
            LinkedListNode node = get(getHash(key), key);
            return node == null ? -1 : node.value;
        }

        private LinkedListNode get(int hash, int key)
        {
            List<LinkedListNode> bucket = buckets[hash];

            foreach (LinkedListNode node in bucket)
            {
                if (node.key == key)
                {
                    return node;
                }
            }

            return null;
        }

        private int getHash(int n)
        {
            return n % size;
        }
    }

    public class LinkedListNode
    {
        public int key;
        public int value;

        public LinkedListNode(int k, int v)
        {
            key = k;
            value = v;
        }
    }
}
