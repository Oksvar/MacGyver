using MacGyver.Client.Collections;
using MacGyver.Client.Models;

namespace MacGyver.Client.Factories
{
    
    public interface IToolsDescriptionFactory
    {
        
        ToolsDescriptionTree PrepareToolsDescriptionTree(AppLinkedList<ToolsDescription> toolsDescriptions);
    }
}
