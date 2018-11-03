using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{

    //  <summary>
    //  Hashing - understand How hashing works https://www.geeksforgeeks.org/hashing-set-1-introduction/
    //  </summary>
    //  Create Struct for KeyValue
    //  Below Source - https://stackoverflow.com/questions/625947/what-is-an-example-of-a-hashtable-implementation-in-c
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

    public class FixedSizeGenericHashTable<K,V>
    {
        // size of the Hashtable
        private readonly int size;

        // create array of buckets to store the values
        private readonly LinkedList<KeyValue<K, V>>[] items;

        // initialize the size and array
        public FixedSizeGenericHashTable(int size)
        {
            this.size = size;
            items = new LinkedList<KeyValue<K, V>>[size];
        }

        // Get the position of key
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<K,V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];

            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }

            return linkedList;
        }

        // Add new Key value in the HashTable 
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

            KeyValue<K, V> keyValue = new KeyValue<K, V>
            {
                Key = key,
                Value = value
            };

            linkedList.AddLast(keyValue);
        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

            bool itemFound = false;
            KeyValue<K, V> foundValue = default(KeyValue<K, V>);

            foreach(KeyValue<K,V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundValue = item;
                }
            }

            if (itemFound)
            {
                linkedList.Remove(foundValue);
            }
        }

        public V FindValue(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);

            foreach (KeyValue<K, V> item in linkedList)
            {
                if(item.Key.Equals(key))
                {
                    return item.Value;
                }
            }

            return default(V);
        }
    }
}
