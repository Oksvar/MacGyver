using MacGyver.Client.Collections;
using MacGyver.Client.Models;

namespace MacGyver.Client.Factories
{
    
    public class ToolsDescriptionFactory : IToolsDescriptionFactory
    {
        
        public ToolsDescriptionTree PrepareToolsDescriptionTree(AppLinkedList<ToolsDescription> toolsDescriptions)
        {
            var tree = new ToolsDescriptionTree();
            ToolsDescriptionNode root = null;

            foreach (var td in toolsDescriptions)
            {
                root = tree.Insert(root, td);
            }

            return tree;
        }
    }
}
