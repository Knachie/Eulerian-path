using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulerian_path
{
    internal class Node
    {
        public int name;
        public int num;
        private bool isEven;

        public Node(int nodeName, int nodeNum)
        {
            name = nodeName;
            num = nodeNum;
            if (nodeNum % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
        }

        public bool AskEven()
        {
            return isEven;
        }
    }
}
