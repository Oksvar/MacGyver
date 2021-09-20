using MacGyver.Client.Collections;
using MacGyver.Client.Models;
using System.Collections.Generic;

namespace MacGyver.Client.Services
{
   
    public class AppService: IAppService
    {
        private AppLinkedList<Quest> _quests;
        private AppLinkedList<ToolsDescription> _toolsDescriptions;

        public AppService()
        {
            _quests = new AppLinkedList<Quest>();
            _quests.Add(new Quest() { Name = "Quest #1", Level = 10 });
            _quests.Add(new Quest() { Name = "Quest #2", Level = 10 });
            _quests.Add(new Quest() { Name = "Quest #3", Level = 10 });
            _quests.Add(new Quest() { Name = "Quest #4", Level = 7 });
            _quests.Add(new Quest() { Name = "Quest #5", Level = 8 });
            _quests.Add(new Quest() { Name = "Quest #6", Level = 7 });
            _quests.Add(new Quest() { Name = "Quest #7", Level = 7 });
            _quests.Add(new Quest() { Name = "Quest #8", Level = 12 });
            _quests.Add(new Quest() { Name = "Quest #9", Level = 7 });
            _quests.Add(new Quest() { Name = "Quest #10", Level = 9 });

            _toolsDescriptions = new AppLinkedList<ToolsDescription>();
            _toolsDescriptions.Add(new ToolsDescription()
            {
                Name = "Tool #1",
                Components = new List<Component<Material>>() {
                    new Component<Material>() { Type = new Fuel(), Quantity = 4 },
                    new Component<Material>() { Type = new Matchstick(), Quantity = 1 },
                }
            });
            _toolsDescriptions.Add(new ToolsDescription()
            {
                Name = "Tool #2",
                Components = new List<Component<Material>>() {
                    new Component<Material>() { Type = new Glass(), Quantity = 5 },
                    new Component<Material>() { Type = new Knife(), Quantity = 5 },
                }
            });
            _toolsDescriptions.Add(new ToolsDescription()
            {
                Name = "Tool #3",
                Components = new List<Component<Material>>() {
                    new Component<Material>() { Type = new Rim(), Quantity = 1 },
                    new Component<Material>() { Type = new Oil(), Quantity = 2 },
                }
            });
            _toolsDescriptions.Add(new ToolsDescription()
            {
                Name = "Tool #4",
                Components = new List<Component<Material>>() {
                    new Component<Material>() { Type = new BrakeFluid(), Quantity = 10 },
                    new Component<Material>() { Type = new Wheel(), Quantity = 10 },
                    new Component<Material>() { Type = new Toaster(), Quantity = 10 }
                }
            });

        }

        
        public AppLinkedList<Quest> GetQuests()
        {
            return _quests;
        }

        
        public AppLinkedList<ToolsDescription> GetToolsDescriptions()
        {
            return _toolsDescriptions;
        }
    }
}
