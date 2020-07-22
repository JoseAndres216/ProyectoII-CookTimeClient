using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_.Data_Structures
{
    public class Node<T>
    {
        [JsonProperty] private T data;
        [JsonProperty] private Node<T> next = null;
        [JsonProperty] private Node<T> prev = null;

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
