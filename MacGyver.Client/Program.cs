using MacGyver.Client.Factories;
using MacGyver.Client.Services;
using System.Linq;
using MacGyver.Client.Collections;
using System;

namespace MacGyver.Client
{
    public class Program
    {
        private static IAppService _appService;

        static Program()
        {
            _appService = new AppService();
        }

        static void Main(string[] args)
        {
            var quests = _appService.GetQuests().OrderBy(t => t.Level);
            var tools = _appService.GetToolsDescriptions().OrderBy(t => t.Usefulness);

            var toolsLen = tools.Count();

            foreach (var quest in quests)
            {
                for (int i = 1; i <= toolsLen; i++)
                {
                    var k = tools.Where(t => !t.IsBusy).DifferentCombinations(i);

                    if (k.Any())
                    {
                        var solve = k.Where(t => t.Sum(l => l.Usefulness) >= quest.Level).OrderBy(t => t.Sum(l => l.Usefulness)).FirstOrDefault();

                        if (solve is null)
                        {
                            continue;
                        }
                        else
                        {
                            solve.ToList().ForEach(t => t.IsBusy = true);

                            Console.WriteLine("Mission complete! / {0}", quest.Name);

                            break;
                        }
                    }
                    else break;
                }
            }

            if (!tools.Where(t => t.IsBusy).Any())
                Console.WriteLine("MacGyver has failed all the missions!");

            Console.ReadLine();
        }
    }

}
