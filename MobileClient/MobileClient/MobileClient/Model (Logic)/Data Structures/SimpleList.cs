using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_.Data_Structures
{
    public class SimpleList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int len;

        public SimpleList()
        {
            head = null;
            tail = null;
            len = 0;
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
