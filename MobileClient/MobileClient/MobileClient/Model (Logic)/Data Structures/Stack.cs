using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_.Data_Structures
{
    public class Stack<T>
    {
        private SimpleList<T> elements;

        public Stack()
        {
            elements = new SimpleList<T>();
        }

        public void setElements(SimpleList<T> elements)
        {
            this.elements = elements;
        }

        public SimpleList<T> getElements()
        {
            return this.elements;
        }
    }
}
