using BISimulator.Context;
using BISimulator.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.Activities
{
    public abstract class BaseActivity
    {
        public abstract void Execute(TreeBuilder tree, FusionContext context);
    }

    public class SelectionActivity : BaseActivity
    {
        public override void Execute(TreeBuilder tree, FusionContext context)
        {
            var root = tree.Root;
            var selectionNode = new SelectionNode()
            {
                ChildNode = root
            };
            tree.Root = selectionNode;
        }
    }

    public class ProjectionActivity : BaseActivity
    {
        public override void Execute(TreeBuilder tree, FusionContext context)
        {
            var root = tree.Root;
            var projectionNode = new ProjectionNode()
            {
                ChildNode = root
            };
            tree.Root = projectionNode;
        }
    }
}
