using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_.Data_Structures
{
    class Stack<T>
    {
        private SimpleList<T> elements;

        public Stack()
        {
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
