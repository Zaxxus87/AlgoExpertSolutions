using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LLClass
{
        public int Value { get; set; }
        public LLClass Next { get; set; }
        public LLClass(int value)
        {
            Value = value;
            Next = null;
        }

        public void Add(int value)
        {
            LLClass root = this;
            while (root.Next != null)
                root = root.Next;
            root.Next = new LLClass(value);
        }

        public string PrintList()
        {
            string output = "";
            LLClass node = this;
            while (node.Next != null)
            {
                output += $"{node.Value} - ";
                node = node.Next;
            }
            output += node.Value; 
            return output;
        }

}

