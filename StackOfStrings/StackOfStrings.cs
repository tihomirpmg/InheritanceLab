 using System;
using System.Collections.Generic;
using System.Linq;

namespace StackOfStrings
{
    class StackOfStrings
    {
        private List<string> st; 
        public StackOfStrings()
        {
            st = new List<string>();
        }
        public void Push(string item)
        {
            st.Add(item);
        }
        public string Pop()
        {
            string lastElement = st.Last();
            st.Remove(lastElement);
            return lastElement;
        }
        public string Peek()
        {
            string lastElement = st.Last();
            return lastElement;
        }
        public bool IsEmpty()
        {
            return st.Count == 0;
        }
    }
}
