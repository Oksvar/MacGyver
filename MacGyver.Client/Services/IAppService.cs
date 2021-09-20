using MacGyver.Client.Collections;
using MacGyver.Client.Models;

namespace MacGyver.Client.Services
{
    
    public interface IAppService
    {
        
        AppLinkedList<Quest> GetQuests();
        
        AppLinkedList<ToolsDescription> GetToolsDescriptions();
    }
}
