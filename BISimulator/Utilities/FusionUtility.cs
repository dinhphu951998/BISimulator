using BISimulator.Activities;
using BISimulator.Context;
using BISimulator.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BISimulator.Utilities
{
    public class FusionUtility
    {
        private List<BaseActivity> activities;

        public FusionContext Context { get; set; }

        public FusionUtility(FusionContext Context)
        {
            activities = new List<BaseActivity>();

            activities.Add(new SelectionActivity());
            activities.Add(new ProjectionActivity());

            this.Context = Context;

        }

        public TreeBuilder BuildTree(FusionContext context)
        {
            TreeBuilder tree = new TreeBuilder()
            {
                Root = new BaseNode()
            };

            foreach (var activity in activities)
            {
                activity.Execute(tree, context);
            }

            return tree;
        }

    }
}
