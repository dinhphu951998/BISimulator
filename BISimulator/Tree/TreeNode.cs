using BISimulator.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.Tree
{
    public class BaseNode
    {
        public BaseNode ChildNode { get; set; }

    }

    public class Operand : BaseNode
    {

    }

    public class SelectionNode : BaseNode
    {

    }

    public class ProjectionNode : BaseNode
    {

    }
}
