using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_1
{
    public class Node
    {
        private  object _data;

        private  Node _next;
        /*
         * /Constructor
         * { } Node (Object data, Node node)
         *
         * Private Fields:
         * {} Object data -
         * {} Node next
         *
         * Public Properties
         *{} Data - get/set the data field
         * {} next - get/set the next field
         *
         *
         */

    
        private Node next;

        public Node(object data, Node next)
        {
            _data = data;
            _next = next;
        }

        public object Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }

    }
}
