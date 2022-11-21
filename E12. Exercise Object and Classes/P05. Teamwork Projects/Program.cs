namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ClubTeam> teams = new List<ClubTeam>();

            CreateTeams(teams);
            JoinTeams(teams);

            PrintValidTeams(teams);
            PrintTeamsToDisband(teams);
        }

        public static void CreateTeams(List<ClubTeam> teams)
        {
            int registerTeamsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < registerTeamsNumber; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split("-");
                string creator = commands[0];
                string teamName = commands[1];
                if (TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    ClubTeam newTeam = new ClubTeam(teamName, creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        public static bool TeamExists(List<ClubTeam> teams, string teamName)
        {
            return teams.Any(x => x.TeamName == teamName);
        }

        public static bool AlreadyCreatedATeam(List<ClubTeam> teams, string creator)
        {
            return teams.Any(x => x.Creator == creator);
        }

        public static void JoinTeams(List<ClubTeam> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command
                    .Split("->");
                string user = cmdArgs[0];
                string teamName = cmdArgs[1];

                if (!TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    ClubTeam teamToJoin = teams
                        .First(x => x.TeamName == teamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        public static bool AlreadyAMemberOfATeam(List<ClubTeam> teams, string user)
        {
            return teams.Any(x => x.Members.Contains(user)) ||
                teams.Any(x => x.Creator == user);
        }

        public static void PrintValidTeams(List<ClubTeam> teams)
        {
            List<ClubTeam> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            foreach (ClubTeam team in teamsWithMembers)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string memberName in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {memberName}");
                }
            }
        }

        public static void PrintTeamsToDisband(List<ClubTeam> teams)
        {
            List<ClubTeam> teamsToDisband = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            Console.WriteLine($"Teams to disband:");
            foreach (ClubTeam disbandTeam in teamsToDisband)
            {
                Console.WriteLine($"{disbandTeam.TeamName}");
            }
        }
    }

    public class ClubTeam
    {
        private readonly List<string> members;

        public ClubTeam(string user, string creator)
        {
            this.TeamName = user;
            this.Creator = creator;
            this.members = new List<string>();
        }

        public string TeamName { get; private set; }

        public string Creator { get; private set; }

        public List<string> Members
            => this.members;

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}
