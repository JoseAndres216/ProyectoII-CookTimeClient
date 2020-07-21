using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_.Data_Structures
{
    class SimpleList<T>
    {
        Node<T> head = null;
        Node<T> tail = null;
        int len = 0;

        public SimpleList()
        {
        }

        public void setHead(Node<T> head)
        {
            this.head = head;
        }

        public Node<T> getHead()
        {
            return this.head;
        }

        public void setTail(Node<T> tail)
        {
            this.tail = tail;
        }

        public Node<T> getTail()
        {
            return this.tail;
        }

        public int getLen()
        {
            return this.len;
        }
    }
}
