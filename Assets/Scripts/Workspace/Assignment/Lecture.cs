using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            //LCT02_SyntaxLinkedList();
            LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            //[Node 1]
            linkedList.AddLast("Node 1");

            //[Node 1] <- [Node 2]
            linkedList.AddLast("Node 2");

            //[Node 0] <- [Node 1] <- [Node 2]
            linkedList.AddFirst("Node 0");

            LinkedListNode<string> firstNode = linkedList.First;
            Debug.Log("First: " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("Last: " + lastNode.Value);

            Debug.Log("firstNode.Next: " + firstNode.Next.Value);
            Debug.Log("firstNode.Next.Next: " + firstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + lastNode.Previous.Value);

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous: null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next: null");

            //[Node 0] < - [Node 0.5] < - [Node 1] < - [Node 1.5] < - [Node 2]
            linkedList.AddAfter(firstNode, "Node 0.5");
            linkedList.AddBefore(lastNode, "Node 1.5");

            LinkedListNode<string> node1 = linkedList.Find("Node 1");

            linkedList.Remove("Node 1");
            linkedList.Remove(node1);
            linkedList.RemoveLast();
            linkedList.RemoveFirst();

            linkedList.Clear();
        }

        public void LCT03_SyntaxHashTable()
        {
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Potion", 1);
            //hashtable.Add(true, "");
            //hashtable.Add(0, 0);
            //hashtable[true] = 1;

            Hashtable table = new Hashtable();
            table.Add(1, "Apple");
            table.Add(2, "Banana");
            table.Add("bad-fruit", "rotten tomato");
            int key = 2;
            Debug.Log($"found {key}");
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();

            //ways to add to a dict
            //"Potion" = Key, "1" = Value
            inv.Add("Potion", 1);
            inv.Add("Apple", 20);
            inv["Banana"] = 5;

            var pickUpItem = "Sword";
            inv[pickUpItem] = 1;

            foreach (KeyValuePair<string, int> pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;

                Debug.Log($"Key: {key} Pair: {value}");
            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);

            inv.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;

                Debug.Log($"Key: {key} Pair: {value}");
            }

            throw new System.NotImplementedException();
        }

        #endregion
    }
}
