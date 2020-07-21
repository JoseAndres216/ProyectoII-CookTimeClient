﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    class Node<T>
    {
        private T data;
        private Node<T> next = null;
        private Node<T> prev = null;

        public Node()
        {
        }

        public void setNext(Node<T> next)
        {
            this.next = next;
        }

        public Node<T> getNext()
        {
            return this.next;
        }

        public void setPrev(Node<T> prev)
        {
            this.prev = prev;
        }

        public Node<T> getPrev()
        {
            return this.prev;
        }

        public void setData(T data)
        {
            this.data = data;
        }

        public T getdata()
        {
            return this.data;
        }
    }
}
