using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<TeamMember> team = new List<TeamMember>();


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

                TeamMember member = new TeamMember();

                member.Name = name;
                member.SkillLevel = int.Parse(skillLevel);
                member.CourageFactor = double.Parse(courageFactor);
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
            foreach (TeamMember member in team)
            {
                teamSkill += member.SkillLevel;
            }



            HeistReport report = new HeistReport();

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
                    report.SuccessCount++;
                }
                else
                {
                    Console.WriteLine("Failure...");
                    report.FailureCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine("REPORT");
            Console.WriteLine("-------");
            Console.WriteLine($"Successes: {report.SuccessCount}");
            Console.WriteLine($"Failures: {report.FailureCount}");
        }
    }
}
