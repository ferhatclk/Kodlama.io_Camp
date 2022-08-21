using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    
    class MyDictionary <K,V>
    {
        KeyValuePair<K, V>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<K, V>[0];

        }

        public void Add(K key, V value)
        {
            if (CheckIfKeyExist(key))
            {
                KeyValuePair<K, V>[] tempArray = items;

                items = new KeyValuePair<K, V>[items.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }

                items[items.Length - 1] = new KeyValuePair<K, V>(key, value);
            }

        }

        private bool CheckIfKeyExist(K key)
        {
            bool result = true;
            foreach (var item in items)
            {
                if (item.Key.Equals( key))
                {
                    result = false;
                }
                    
            }
            return result; 
        }

        public int Count
        {
            get { return items.Length; }
        }


    }
}
