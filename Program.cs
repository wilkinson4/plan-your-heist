using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<Dictionary<string, string>> team = new List<Dictionary<string, string>>();

            
            Console.WriteLine("Bank Difficulty> ");
            int bankDifficulty = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Name> ");
            string name = Console.ReadLine();
            while (name != "")
            {
                Console.WriteLine("Skill Level> ");
                string skillLevel = Console.ReadLine();

                Console.WriteLine("Courage Factor> ");
                string courageFactor = Console.ReadLine();

                Dictionary<string, string> member = new Dictionary<string, string>() {
                    {"Name", name},
                    { "SkillLevel", skillLevel},
                    { "CourageFactor", courageFactor}
                };
                team.Add(member);

                Console.WriteLine();
                // get the next team member
                Console.WriteLine("Name> ");
                name = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Number of runs> ");
            int trialRunCount = int.Parse(Console.ReadLine());
            Console.WriteLine();


            int teamSkill = 0;
            foreach (Dictionary<string, string> member in team)
            {
                teamSkill += int.Parse(member["SkillLevel"]);
            }


            Dictionary<string, int> report = new Dictionary<string, int>(){
                {"Successes", 0},
                {"Failures", 0}
            };

            for (int i = 0; i < trialRunCount; i++)
            {
                Random generator = new Random();
                int luckValue = generator.Next(-10, 11);
                int trialRunBankDifficulty = bankDifficulty + luckValue;



                Console.WriteLine($"Team Skill Level: {teamSkill}");
                Console.WriteLine($"Bank Difficulty: {trialRunBankDifficulty}");

                if (teamSkill >= trialRunBankDifficulty)
                {
                    Console.WriteLine("YOU RICH!");
                    report["Successes"]++;
                }
                else
                {
                    Console.WriteLine("Failure...");
                    report["Failures"]++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("REPORT");
            Console.WriteLine("-------");
            Console.WriteLine($"Successes: {report["Successes"]}");
            Console.WriteLine($"Failures: {report["Failures"]}");
        }
    }
}
