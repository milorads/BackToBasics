using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToBasics.Helpers
{
    public class QueueNode
    {
        public int Data { get; set; }
        public QueueNode Next { get; set; }
        public QueueNode(int data)
        {
            this.Data = data;
        }
    }
}
