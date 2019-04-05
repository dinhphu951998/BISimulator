using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.Tree
{
    public class TreeBuilder
    {
        public BaseNode Root { get; set; }
        public TreeBuilder()
        {
            Root = new Operand();
        }
    }

   
}
