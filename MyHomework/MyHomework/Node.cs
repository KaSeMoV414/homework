using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Node
    {
        public Student Data { get; set; }

        public Node Next { get; set; }

        public Node() { }

        public Node(Student data)
        {
            this.Data = data;
        }
    }
}
