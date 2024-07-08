using System;
using System.Collections.Generic;
using System.Linq;
using Football.Models;
using Football.DataAccess;

namespace dz13._06
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballContext())
            {

                context.Database.EnsureCreated();


                var teams = new List<Team>
                {
                    new Team { TeamName = "Dynamo", City = "Kyiv", Wins = 10, Losses = 2, Draws = 3 },
                    new Team { TeamName = "Shakhtar", City = "Donetsk", Wins = 9, Losses = 3, Draws = 3 },
                    new Team { TeamName = "Karpaty", City = "Lviv", Wins = 5, Losses = 7, Draws = 3 },
                    new Team { TeamName = "Chornomorets", City = "Odesa", Wins = 4, Losses = 8, Draws = 3 },
                    new Team { TeamName = "Metalist", City = "Kharkiv", Wins = 3, Losses = 9, Draws = 3 }
                };

                context.Teams.AddRange(teams);
                context.SaveChanges();


                var allTeams = context.Teams.ToList();
                foreach (var team in allTeams)
                {
                    Console.WriteLine($"Name: {team.TeamName}, City: {team.City}, Wins: {team.Wins}, Losses: {team.Losses}, Draws: {team.Draws}");
                }
            }
        }
    }
}
