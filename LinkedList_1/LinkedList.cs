using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_1
{
   public class LinkedList
    {
        /*
         * Constructor
         * LinkedList() - Initializes the private fields
         *
         * Private Fields
         * Node head - Is a refernce to the First node in the list
         * int Size - The Current Size of the list
         *
         * Public Properties
         * Empty - If the list is empty
         * Count - How many items are in the list
         * Indexer - Access Data like an array
         *
         * Methods
         * Add(int index, onject o) - Add an item to list at specified index
         * Add(object o) - Add an item to the END of the list
         * Remove(int index) - Remove the item in the list at the specified index
         * Clear() - Clear the list
         * IndexOf(object o) - get the index of the item in the list, if not in the list return -1
         * Contains(object o) - If the list contains the object
         * Get(int index) - Get item at the specified index
         */

        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public bool Empty
        {
            get
            {
                return this.count == 0;
            }
        }

        public int Count
        {
            get { return this.count;}
            //set { this.count = value; }
        }

        public object Add(int index, object o)
        {
            if(index < 0 )
                throw new ArgumentOutOfRangeException($"Index: {index}");

            if (index > count)
            {
                index = count;
            }

            Node current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(o, current.Next);
            }

            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if(index < 0)
                throw  new ArgumentOutOfRangeException($"Index: {index}");

            if (this.Empty)
                return null;
            if (index > this.count)
                index = count - 1;

            Node current = this.head;

            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data;
                current.Next = current.Next.Next;
            }

            count--;
            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(object o)
        {
            Node current = this.head;

            for (int i = 0; i < this.count; i++)
            {
                if (current.Data.Equals(o))
                    return i;
                current = current.Next;
            }

            return -1;
            
        }

        public bool Contains(object o)
        {
            return this.IndexOf(o) >= 0;
        }
    }
}
